using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Concrete;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CoreDemo.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Writer p)
		{
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail==p.WriterMail && x.WriterPassword==p.WriterPassword);
			if(datavalue!=null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.WriterMail)
				};
				var useridentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Dashboard");
				//return RedirectToRoute("dashboard");
			}
			else
			{
				return View();
			}
		}
		public IActionResult AccessDenied()
		{
			return View();
		}

	}
}

//Context c = new Context();
//var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail==p.WriterMail && x.WriterPassword==p.WriterPassword);
//if (datavalue!=null)
//{
//	HttpContext.Session.SetString("username", p.WriterMail);
//	return RedirectToAction("Index", "Writer");
//}
//else
//{
//	return View();
//}
