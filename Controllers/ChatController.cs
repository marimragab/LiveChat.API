using LiveChat.API.Hubs;
using LiveChat.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LiveChat.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChatController : ControllerBase
	{
		private readonly IHubContext<ChatHub> hubContext;

		public ChatController(IHubContext<ChatHub> _hubContext)
		{
			hubContext = _hubContext;
		}

	}
}
