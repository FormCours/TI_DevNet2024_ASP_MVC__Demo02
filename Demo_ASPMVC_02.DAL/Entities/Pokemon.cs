using System.ComponentModel.DataAnnotations;

namespace Demo_ASPMVC_02.DAL.Entities
{
    public class Pokemon
    {
        [Key]
        public int Numero { get; set; }

        public string Nom { get; set; }

        public int Vie { get; set; }
        public int? PreEvolutionNumero { get; set; }

        public PokemonType Type1 { get; set; }
        public int Type1Id { get; set; }

        public PokemonType Type2 { get; set; }
        public int? Type2Id { get; set; }

        public Pokemon PreEvolution { get; set; }
    }
}
