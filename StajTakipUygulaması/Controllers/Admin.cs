using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StajTakipUygulaması.Controllers
{

	public class Admin : Controller
	{
		public IActionResult AdminMain()
		{
			return View();
		}
	}
}
