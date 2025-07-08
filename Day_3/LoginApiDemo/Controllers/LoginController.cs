using Microsoft.AspNetCore.Mvc;
using LoginApiDemo.Models; // 👈 Correct namespace

namespace LoginApiDemo.Controllers
{
	[ApiController]
	[Route("api/login")]  // 👈 Clear and fixed route
	public class LoginController : ControllerBase
	{
		[HttpPost]
		public IActionResult Login([FromBody] LoginModel model)
		{
			string validUsername = "admin";
			string validPassword = "1234";

			if (model.Username == validUsername && model.Password == validPassword)
			{
				return Ok(new { message = "Login Successfully" });
			}
			else
			{
				return Unauthorized(new { message = "Invalid credentials" });
			}
		}
	}
}
