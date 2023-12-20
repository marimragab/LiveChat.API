using LiveChat.API.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace LiveChat.API.Hubs
{
	public class ChatHub:Hub<IChatHub>
	{
		private ChatEntities _dbEntities;
        public ChatHub(ChatEntities dbEntities)
        {
			_dbEntities = dbEntities;
        }

		public async Task SendMessage(string content, int receiverId)
		{
			// Get the sender user from the database using the connection ID
			var senderId = GetUserIdFromConnectionId(Context.ConnectionId);
			var sender = await _dbEntities.Users.FindAsync(senderId);

			// Create a new message
			var message = new Message
			{
				Content = content,
				Sended = DateTime.Now,
				SenderId = senderId,
				ReceiverId = receiverId
			};

			// Save the message to the database
			_dbEntities.Messages.Add(message);
			await _dbEntities.SaveChangesAsync();

			// Send the message to the receiver
			var receiverConnectionId = GetConnectionIdFromUserId(receiverId);
			if (receiverConnectionId != null)
			{
				await Clients.Client(receiverConnectionId).ReceiveMessage( sender.Name, message.Content);
			}
		}

		public override async Task OnConnectedAsync()
		{
			var userId = GetUserIdFromContext();
			var connectionId = Context.ConnectionId;

			// Save the user's connection to the database
			var userConnection = new UserConnection { UserId = userId, ConnectionId = connectionId };
			_dbEntities.UserConnections.Add(userConnection);
			await _dbEntities.SaveChangesAsync();

			// Broadcast the updated list of online users
			var onlineUsers = GetOnlineUsers();
			await Clients.All.OnlineUsers(onlineUsers);

			await base.OnConnectedAsync();
		}

		public override async Task OnDisconnectedAsync(Exception exception)
		{
			var connectionId = Context.ConnectionId;

			// Remove the user's connection from the database
			var userConnection = _dbEntities.UserConnections
				                                        .FirstOrDefault(uc => uc.ConnectionId == connectionId);
			if (userConnection != null)
			{
				_dbEntities.UserConnections.Remove(userConnection);
				await _dbEntities.SaveChangesAsync();
			}

			// Broadcast the updated list of online users
			var onlineUsers = GetOnlineUsers();
			await Clients.All.OnlineUsers(onlineUsers);

			await base.OnDisconnectedAsync(exception);
		}

		private int GetUserIdFromContext()
		{
			// Implement logic to retrieve the user ID from the context (e.g., from claims)
			// For simplicity, assuming it's a claim called "UserId"
			var userIdClaim = Context.User?.FindFirst("UserId");
			return userIdClaim != null ? int.Parse(userIdClaim.Value) : 0;
		}

		private string GetConnectionIdFromUserId(int userId)
		{
			// Implement logic to retrieve the connection ID from the database based on the user ID
			var userConnection = _dbEntities.UserConnections.FirstOrDefault(uc => uc.UserId == userId);
			return userConnection?.ConnectionId;
		}

		private int GetUserIdFromConnectionId(string connectionId)
		{
			// Implement logic to retrieve the user ID from the database based on the connection ID
			var userConnection = _dbEntities.UserConnections.FirstOrDefault(uc => uc.ConnectionId == connectionId);
			return userConnection?.UserId ?? 0;
		}

		private List<User> GetOnlineUsers()
		{
			// Implement logic to retrieve the list of online users from the database
			var onlineUserIds = _dbEntities.UserConnections
				                                    .Select(uc => uc.UserId).ToList();
			return _dbEntities.Users.Where(u => onlineUserIds.Contains(u.Id)).ToList();
		}
	}
}
