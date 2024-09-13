using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPMVC_02.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
