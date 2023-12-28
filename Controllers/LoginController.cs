using LiveChat.API.Models;
using LiveChat.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LiveChat.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		//private readonly UserService _userService;

		//public LoginController(UserService userService)
		//{
		//	_userService = userService;
		//}

		//[HttpPost]
		//public async Task<IActionResult> Login(Login loginModel)
		//{
		//	var user=_userService.AuthenticateUser(loginModel.Email, loginModel.Password);
		//	if (user != null)
		//	{
		//		return Ok(user);
		//	}
		//	else
		//	{
		//		return Unauthorized();
		//	}
		//}
	}
}
