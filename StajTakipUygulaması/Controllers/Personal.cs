using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StajTakipUygulaması.Controllers
{

	public class Personal : Controller
	{
		public IActionResult PersonalMain()
		{
			return View();
		}
	}
}
