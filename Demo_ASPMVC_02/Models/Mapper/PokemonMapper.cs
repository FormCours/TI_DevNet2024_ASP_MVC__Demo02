using Demo_ASPMVC_02.DAL.Entities;

namespace Demo_ASPMVC_02.Models.Mapper
{
    public static class PokemonMapper
    {
        public static PokemonViewModel ToViewModel(this Pokemon entity)
        {
            return new PokemonViewModel
            {
                Numero = entity.Numero,
                Nom = entity.Nom,
                Vie = entity.Vie,
                PreEvolutionNumero = entity.PreEvolutionNumero,
                Type1Id = entity.Type1Id,
                Type2Id = entity.Type2Id
            };
        }
        public static PokemonFormModel ToFormModel(this Pokemon entity)
        {
            return new PokemonFormModel
            {
                Numero = entity.Numero,
                Nom = entity.Nom,
                Vie = entity.Vie,
                PreEvolutionNumero = entity.PreEvolutionNumero,
                Type1Id = entity.Type1Id,
                Type2Id = entity.Type2Id
            };
        }
        public static Pokemon ToEntity(this PokemonViewModel viewModel)
        {
            return new Pokemon
            {
                Numero = viewModel.Numero,
                Nom = viewModel.Nom,
                Vie = viewModel.Vie,
                PreEvolutionNumero = viewModel.PreEvolutionNumero,
                Type1Id = viewModel.Type1Id,
                Type2Id = viewModel.Type2Id
            };
        }
        public static Pokemon ToEntity(this PokemonFormModel formModel)
        {
            return new Pokemon
            {
                Numero = formModel.Numero,
                Nom = formModel.Nom,
                Vie = formModel.Vie,
                PreEvolutionNumero = formModel.PreEvolutionNumero,
                Type1Id = formModel.Type1Id,
                Type2Id = formModel.Type2Id
            };
        }
    }
}
