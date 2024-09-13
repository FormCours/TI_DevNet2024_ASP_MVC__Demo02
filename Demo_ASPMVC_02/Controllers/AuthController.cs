using Demo_ASPMVC_02.Data;
using Demo_ASPMVC_02.Models;
using Isopoh.Cryptography.Argon2;
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

            // Check du mot de passe
            var member = FakeMemberData.Members.SingleOrDefault(m => m.Email == model.Email);

            if(member is null || !Argon2.Verify(member.HashPassword, model.Password))
            {
                ModelState.AddModelError("Password", "Bad credentials...");
                return View(model);
            }

            // Connexion de l'utilisateur via la session
            HttpContext.Session.SetInt32("MemberId", member.Id);
            HttpContext.Session.SetString("Pseudo", member.Pseudo);

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
            FakeMemberData.Member member = new FakeMemberData.Member()
            {
                Id = FakeMemberData.Members.Max(m => m.Id) + 1,
                Email = model.Email,
                Pseudo = model.Pseudo,
                AllowNewsletter = model.AllowNewsletter,
                BirthDate = model.BirthDate,
                HashPassword = Argon2.Hash(model.Password)
            };
            FakeMemberData.Members.Add(member);

            return RedirectToAction(nameof(Login));
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
