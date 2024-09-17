using Demo_ASPMVC_02.DAL.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo_ASPMVC_02.Models
{
    public class PokemonFormModel
    {
        [DisplayName("Le numéro du pokémon")]
        [Required]
        public int Numero { get; set; }

        [DisplayName("Le nom du pokémon")]
        [Required]
        [MaxLength(100)]
        [RegularExpression("[a-zA-Z]+")]
        public string Nom { get; set; }

        [DisplayName("La vie du pokémon")]
        [Required]
        public int Vie { get; set; }

        [DisplayName("Le numéro de la pré-évolution")]
        public int? PreEvolutionNumero { get; set; }

        public int Type1Id { get; set; }
        public int? Type2Id { get; set; }

        public List<PokemonFormModel> Pokemons { get; set; } = [];
        public List<TypeFormModel>  Types { get; set; } = [];
    }
}
