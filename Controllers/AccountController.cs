using LiveChat.API.DTOs;
using LiveChat.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LiveChat.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[EnableCors("AllowSpecificOrigin")]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IConfiguration config;
		public AccountController(UserManager<ApplicationUser> userManager,IConfiguration config)
        {
			this.userManager = userManager;
			this.config = config;
		}
        //Registration
        [HttpPost("register")]
		public async Task<IActionResult> Registration(RegisterUserDTO userDTO)
		{
			 if(ModelState.IsValid) 
			 {
				ApplicationUser user = new ApplicationUser();
				user.UserName = userDTO.UserName;
				user.Email = userDTO.Email;
				IdentityResult result=await userManager.CreateAsync(user,userDTO.Password);
				if(result.Succeeded) { return Ok ("Account Added"); }
				return BadRequest(result.Errors.FirstOrDefault());
			 }

			 return BadRequest(ModelState);
		}

		//Login

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginUserDTO userDTO)
		{
			if (ModelState.IsValid) 
			{
				ApplicationUser user=await userManager.FindByNameAsync(userDTO.UserName);
				if (user != null)
				{
					bool found=await userManager.CheckPasswordAsync(user, userDTO.Password);
					if (found)
					{
						var claims = new List<Claim>();
						claims.Add(new Claim(ClaimTypes.Name, user.UserName));
						claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
						claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

						//get roles
						var roles = await userManager.GetRolesAsync(user);
                        foreach (var role in roles)
                        {
						   claims.Add(new Claim(ClaimTypes.Role, role));

						}

						SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:SecretKey"]));  
						SigningCredentials signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

						JwtSecurityToken token = new JwtSecurityToken(
							issuer: config["JWT:IssuerUrl"],
							audience: config["JWT:AudianceUrl"],
							claims:claims,
							expires:DateTime.Now.AddHours(1),
							signingCredentials:signingCredentials
						);

						return Ok( new
						{
							token=new JwtSecurityTokenHandler().WriteToken(token),
					 		expiration=token.ValidTo
						});
					}
				}
				return Unauthorized();
			}

			return Unauthorized();
		}
	}
}
