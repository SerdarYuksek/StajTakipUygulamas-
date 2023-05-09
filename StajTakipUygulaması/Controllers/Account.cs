using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace StajTakipUygulaması.Controllers
{
	[AllowAnonymous]
	public class Account : Controller
	{

		DataContext dc = new DataContext();

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(Kullanici p) //Sisteme Giriş Fonksiyonu
		{
			GirisValidator gv = new GirisValidator();
			ValidationResult result = gv.Validate(p);



			if (result.IsValid)  //Validasyon kontrolü
			{
				var bilgiler = dc.Kullanicis.FirstOrDefault(x => x.TCNO == p.TCNO && x.Password == p.Password);
				if (bilgiler != null)  //Giriş Doğruluk kontrolü
				{
					var Claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,bilgiler.AdSoyad),
				};

					// Role Göre İlgili Sayfaya Yönlendirme
					if (bilgiler.Rol == 0)
					{
						var useridentity = new ClaimsIdentity(Claims, "a");
						ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
						await HttpContext.SignInAsync(principal);
						return RedirectToAction("AdminMain", "Admin");
					}
					else if (bilgiler.Rol == 1)
					{
						var useridentity = new ClaimsIdentity(Claims, "b");
						ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
						await HttpContext.SignInAsync(principal);
						return RedirectToAction("PersonalMain", "Personal");
					}
					else if (bilgiler.Rol == 2)
					{
						var useridentity = new ClaimsIdentity(Claims, "c");
						ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
						await HttpContext.SignInAsync(principal);
						return RedirectToAction("StudentMain", "Student");
					}
				}
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			ViewBag.hata = "TCNO veya Şifreniz hatalıdır";
			return View();
		}



		[HttpGet]
		public async Task<IActionResult> LogOut()   //Sistemden Çıkış Fonksiyonu
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login", "Account");
		}


		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(Kullanici data)
		{
			return View();
		}
	}
}
