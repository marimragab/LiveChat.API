using LiveChat.API.Models;

namespace LiveChat.API.Hubs
{
	public interface IChatHub
	{
		Task ReceiveMessage(string user, string message);
		Task OnlineUsers(List<User>onlineUsers);

	}
}
