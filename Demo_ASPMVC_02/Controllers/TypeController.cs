using Demo_ASPMVC_02.DAL.Repositories;
using Demo_ASPMVC_02.Data;
using Demo_ASPMVC_02.Models;
using Demo_ASPMVC_02.Models.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPMVC_02.Controllers
{
    public class TypeController(TypeRepository repository) : Controller
    {
        public IActionResult Index()
        {
            List<TypeViewModel> types = repository.GetAll().Select(t => t.ToViewModel()).ToList();
            return View(types);
        }
    }
}
