using LiveChat.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace LiveChat.API.Hubs
{
	public class ChatHub:Hub<IChatHub>
	{
		private readonly ChatEntities _dbContext;
		private readonly UserManager<ApplicationUser> _userManager;

		public ChatHub(ChatEntities dbContext,UserManager<ApplicationUser> userManager)
        {
			_dbContext = dbContext;
			_userManager = userManager;
        }

		public async Task JoinChat(string userId)
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, userId);
		}

		public async Task SendMessage(string receiverId,string message)
		{
			var senderId = Context.UserIdentifier;

			var chatMessage = new Message
			{
				SenderId = senderId,
				ReceiverId = receiverId,
				Content = message,
			};

			_dbContext.Messages.Add(chatMessage);
			await _dbContext.SaveChangesAsync();

			await Clients.User(receiverId).ReceiveMessage(senderId, message);
		}

		//public override async Task OnConnectedAsync()
		//{
		//	var userId = GetUserIdFromContext();
		//	var connectionId = Context.ConnectionId;

		//	// Save the user's connection to the database
		//	var userConnection = new UserConnection { UserId = userId, ConnectionId = connectionId };
		//	_dbEntities.UserConnections.Add(userConnection);
		//	await _dbEntities.SaveChangesAsync();

		//	// Broadcast the updated list of online users
		//	var onlineUsers = GetOnlineUsers();
		//	await Clients.All.OnlineUsers(onlineUsers);

		//	await base.OnConnectedAsync();
		//}

		//public override async Task OnDisconnectedAsync(Exception exception)
		//{
		//	//var connectionId = Context.ConnectionId;

		//	//// Remove the user's connection from the database
		//	//var userConnection = _dbEntities.UserConnections
		//	//	                                        .FirstOrDefault(uc => uc.ConnectionId == connectionId);
		//	//if (userConnection != null)
		//	//{
		//	//	_dbEntities.UserConnections.Remove(userConnection);
		//	//	await _dbEntities.SaveChangesAsync();
		//	//}

		//	//// Broadcast the updated list of online users
		//	//var onlineUsers = GetOnlineUsers();
		//	//await Clients.All.OnlineUsers(onlineUsers);

		//	await base.OnDisconnectedAsync(exception);
		//}

		//private int GetUserIdFromContext()
		//{
		//	var userIdClaim = Context.User?.FindFirst("UserId");
		//	return userIdClaim != null ? int.Parse(userIdClaim.Value) : 0;
		//}

		//private string GetConnectionIdFromUserId(string userId)
		//{
		//	var userConnection = _dbEntities.UserConnections.FirstOrDefault(uc => uc.UserId == userId);
		//	return userConnection?.ConnectionId;
		//}

		//private string GetUserIdFromConnectionId(string connectionId)
		//{
		//	var userConnection = _dbEntities.UserConnections.FirstOrDefault(uc => uc.ConnectionId == connectionId);
		//	return userConnection?.UserId ?? "";
		//}

		//private List<User> GetOnlineUsers()
		//{
		//	var onlineUserIds = _dbEntities.UserConnections
		//											.Select(uc => uc.UserId).ToList();
			
		//	return _dbEntities.ApplicationUser.Where(u => onlineUserIds.Contains(u.Id)).ToList();
		//}
	}
}
