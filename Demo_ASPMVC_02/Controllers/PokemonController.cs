using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPMVC_02.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
