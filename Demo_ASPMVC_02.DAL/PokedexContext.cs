using DDEMO_ASPMVC_02.DAL.Data;
using Demo_ASPMVC_02.DAL.Configurations;
using Demo_ASPMVC_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo_ASPMVC_02.DAL
{
    public class PokedexContext: DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<PokemonType> Types { get; set; }

        public PokedexContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new PokemonTypeConfig());
            modelBuilder.ApplyConfiguration(new PokemonConfig());

            modelBuilder.ApplyConfiguration(new DataSetPokemonType());
            modelBuilder.ApplyConfiguration(new DataSetPokemon());

        }
    }
}
