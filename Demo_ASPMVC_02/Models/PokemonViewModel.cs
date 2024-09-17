using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Demo_ASPMVC_02.Models
{
    public class PokemonViewModel
    {
        [DisplayName("Numéro")]
        public int Numero { get; set; }

        [DisplayName("Nom")]
        public string Nom { get; set; }

        [DisplayName("Vie")]
        public int Vie { get; set; }

        [DisplayName("Numéro de la préévolution")]
        public int? PreEvolutionNumero { get; set; }

        public int Type1Id { get; set; }
        public int? Type2Id { get; set; }

        public PokemonViewModel PreEvolution { get; set; }
    }
}
