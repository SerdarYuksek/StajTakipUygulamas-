using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StajTakipUygulaması.Controllers
{
	
	public class Student : Controller
	{
		public IActionResult StudentMain()
		{
			return View();
		}
	}
}
