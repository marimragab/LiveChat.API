using LiveChat.API.Migrations;
using LiveChat.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LiveChat.API.Hubs
{
	public class ChatHub:Hub<IChatHub>
	{
		private readonly ChatEntities _dbContext;
		private readonly UserManager<ApplicationUser> _userManager;

		public ChatHub(ChatEntities dbContext, UserManager<ApplicationUser> userManager)
		{
			_dbContext = dbContext;
			_userManager = userManager;
		}

	
		//public async Task SendMessage(string receiverId, string message)
		//{
		//	var senderId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

		//	if (!string.IsNullOrEmpty(senderId))
		//	{
		//		await Clients.User(receiverId).ReceiveMessage(senderId, message);

		//		var chatMessage = new Message
		//		{
		//			SenderId = senderId,
		//			ReceiverId = receiverId,
		//			Content = message,
		//			IsSent = true,
		//		};

		//		await _dbContext.Messages.AddAsync(chatMessage);
		//		await _dbContext.SaveChangesAsync();
		//	}
		//}

		public async Task SendMessage(string content, string senderId, string receiverId)
		{
			var sender = await _userManager.FindByIdAsync(senderId);
			if (receiverId != null)
			{
				await Clients.User(receiverId).ReceiveMessage(sender.UserName, content,DateTime.Now);
			}

			var message = new Message
			{
				Content = content,
				MessageDate = DateTime.Now,
				SenderId = senderId,
				ReceiverId = receiverId
			};

			await _dbContext.Messages.AddAsync(message);
			await _dbContext.SaveChangesAsync();

			var userConnection = new UserConnection { UserId = senderId, ConnectionId = Context.ConnectionId };
			await _dbContext.UserConnections.AddAsync(userConnection);
			await _dbContext.SaveChangesAsync();
		}

		public async Task JoinChat(string userId)
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, userId);
		}

		public override async Task OnConnectedAsync()
		{
			var userId = Context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

			if (!string.IsNullOrEmpty(userId))
			{
				var connection = new UserConnection
				{
					ConnectionId = Context.ConnectionId,
					UserId = userId
				};

				_dbContext.UserConnections.Add(connection);
				await _dbContext.SaveChangesAsync();
			}

			await base.OnConnectedAsync();
		}

		public override async Task OnDisconnectedAsync(Exception exception)
		{
			var connection = await _dbContext.UserConnections
				.SingleOrDefaultAsync(c => c.ConnectionId == Context.ConnectionId);

			if (connection != null)
			{
				_dbContext.UserConnections.Remove(connection);
				await _dbContext.SaveChangesAsync();
			}

			await base.OnDisconnectedAsync(exception);
		}

	}
}
