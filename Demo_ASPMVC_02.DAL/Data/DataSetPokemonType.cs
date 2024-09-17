using Demo_ASPMVC_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDEMO_ASPMVC_02.DAL.Data
{
    public class DataSetPokemonType : IEntityTypeConfiguration<PokemonType>
    {
        public void Configure(EntityTypeBuilder<PokemonType> builder)
        {
            builder.HasData(
                new PokemonType
                {
                    Id = 1,
                    Nom = "Plante"
                },
                new PokemonType
                {
                    Id = 2,
                    Nom = "Eau"
                },
                new PokemonType
                {
                    Id = 3,
                    Nom = "Feu"
                },
                new PokemonType
                {
                    Id = 4,
                    Nom = "Roche"
                },
                new PokemonType
                {
                    Id = 5,
                    Nom = "Normal"
                },
                new PokemonType
                {
                    Id = 6,
                    Nom = "Psy"
                }
            );
        }
    }
}
