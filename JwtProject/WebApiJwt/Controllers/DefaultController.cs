using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
	public class DefaultController : Controller
	{
		[HttpGet("[action]")]
		public IActionResult Test()
		{
			return Ok(new CreateToken().TokenCreate());
		}

		[Authorize]
		[HttpGet("[action]")]
		public IActionResult Test2()
		{
			return Ok("Hoş Geldiniz.");
		}
	}
}
