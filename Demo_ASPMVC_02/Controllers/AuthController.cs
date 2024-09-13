using Demo_ASPMVC_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPMVC_02.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] AuthLoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Connexion de l'utilisateur via la session

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] AuthRegisterFormModel model)
        {
            if(model.BirthDate is not null && model.BirthDate >= DateTime.Today.AddYears(-12))
            {
                ModelState.AddModelError(nameof(AuthRegisterFormModel.BirthDate), "T'as po 12 ans o((>ω< ))o");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Création d'un compte dans l'application

            return RedirectToAction(nameof(Login));
        }

        public IActionResult Logout()
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
