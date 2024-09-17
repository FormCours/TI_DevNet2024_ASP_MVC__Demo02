using Demo_ASPMVC_02.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ASPMVC_02.DAL.Repositories
{
    public class PokemonRepository(PokedexContext pokedexContext)
    {
        public List<Pokemon> GetAll()
        {
            return pokedexContext.Pokemons.ToList();
        }

        public Pokemon? GetOneById(int numero)
        {
            return pokedexContext.Pokemons.FirstOrDefault(p => p.Numero == numero);
        }

        public Pokemon Insert(Pokemon pokemon)
        {
            Pokemon inserted = pokedexContext.Pokemons.Add(pokemon).Entity;
            pokedexContext.SaveChanges();

            return inserted;
        }

        public Pokemon Update(Pokemon pokemon)
        {
            Pokemon updated = pokedexContext.Pokemons.Update(pokemon).Entity;
            pokedexContext.SaveChanges();

            return updated;
        }

        public void Delete(Pokemon pokemon)
        {
            pokedexContext.Remove(pokemon);
            pokedexContext.SaveChanges();
        }
    }
}
