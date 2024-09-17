using Demo_ASPMVC_02.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo_ASPMVC_02.DAL.Repositories
{
    public class TypeRepository(PokedexContext pokedexContext)
    {
        public List<PokemonType> GetAll()
        {
            return pokedexContext.Types.ToList();
        }

        public PokemonType? GetOneBy(int id)
        {
            return pokedexContext.Types.FirstOrDefault(t => t.Id == id);
        }
        public PokemonType Insert(PokemonType type)
        {
            PokemonType inserted = pokedexContext.Types.Add(type).Entity;
            pokedexContext.SaveChanges();

            return inserted;
        }
    }
}
