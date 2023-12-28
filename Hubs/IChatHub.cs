using LiveChat.API.Models;

namespace LiveChat.API.Hubs
{
	public interface IChatHub
	{
		Task ReceiveMessage(string senderName, string message,DateTime  messgaeDate);
		Task OnlineUsers(List<User>onlineUsers);

	}
}
