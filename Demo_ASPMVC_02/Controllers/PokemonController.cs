using Demo_ASPMVC_02.DAL.Entities;
using Demo_ASPMVC_02.DAL.Repositories;
using Demo_ASPMVC_02.Data;
using Demo_ASPMVC_02.Models;
using Demo_ASPMVC_02.Models.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASPMVC_02.Controllers
{
    public class PokemonController(PokemonRepository repository, TypeRepository typeRepository) : Controller
    {
        public IActionResult Index()
        {
            List<PokemonViewModel> pokemons = repository.GetAll().Select(p => p.ToViewModel()).ToList();

            return View(pokemons);
        }

        public IActionResult Details(int id)
        {
            PokemonViewModel? pokemon = repository.GetOneById(id)?.ToViewModel();
            if (pokemon is null)
            {

                return NotFound();
            }
            return View(pokemon);
        }

        public IActionResult Create()
        {
            List<PokemonFormModel> pokemons = repository.GetAll().Select(p => p.ToFormModel()).ToList();
            List<TypeFormModel> types = typeRepository.GetAll().Select(t => t.ToFormModel()).ToList();

            return View(new PokemonFormModel
            {
                Pokemons = pokemons,
                Types = types
            });
        }
        [HttpPost]
        public IActionResult Create([FromForm] PokemonFormModel model)
        {
            if (ModelState.IsValid)
            {
                Pokemon pokemon = repository.Insert(model.ToEntity());

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            PokemonFormModel? pokemon = repository.GetOneById(id)?.ToFormModel();
            if (pokemon is null)
            {
                return NotFound();
            }

            List<PokemonFormModel> pokemons = repository.GetAll().Select(p => p.ToFormModel()).ToList();
            List<TypeFormModel> types = typeRepository.GetAll().Select(t => t.ToFormModel()).ToList();

            pokemon.Types = types;
            pokemon.Pokemons = pokemons;

            return View(pokemon);
        }
        [HttpPost]
        public IActionResult Edit([FromForm] PokemonFormModel model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model.ToEntity());

                return RedirectToAction(nameof(Index));
            }

            return View();
        }
        public IActionResult Delete([FromRoute] int id)
        {
            PokemonViewModel? pokemon = repository.GetOneById(id).ToViewModel();
            if (pokemon is null)
            {
                return NotFound();
            }

            if (repository.GetAll().Exists(p => p.PreEvolutionNumero == id))
            {
                return BadRequest();
            }
            repository.Delete(pokemon.ToEntity());

            return RedirectToAction(nameof(Index));
        }
    }
}
