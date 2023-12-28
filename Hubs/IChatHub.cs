using LiveChat.API.Models;

namespace LiveChat.API.Hubs
{
	public interface IChatHub
	{
		Task ReceiveMessage(string senderId, string message);
		Task OnlineUsers(List<User>onlineUsers);

	}
}
