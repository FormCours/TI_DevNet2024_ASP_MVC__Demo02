using Demo_ASPMVC_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDEMO_ASPMVC_02.DAL.Data
{
    public class DataSetPokemon : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasData(
                new Pokemon
                {
                    Numero = 1,
                    Nom = "Bulbizarre",
                    Vie = 100,
                    PreEvolutionNumero = null,
                    Type1Id = 1,
                    Type2Id = null
                },
            new Pokemon
            {
                Numero = 2,
                Nom = "Herbizarre",
                Vie = 150,
                PreEvolutionNumero = 1,
                Type1Id = 1,
                Type2Id = null
            },
            new Pokemon
            {
                Numero = 3,
                Nom = "Florizarre",
                Vie = 200,
                PreEvolutionNumero = 2,
                Type1Id = 1,
                Type2Id = null
            },
            new Pokemon
            {
                Numero = 4,
                Nom = "Carapuce",
                Vie = 100,
                PreEvolutionNumero = null,
                Type1Id = 2,
                Type2Id = null
            }
            );
        }
    }
}
