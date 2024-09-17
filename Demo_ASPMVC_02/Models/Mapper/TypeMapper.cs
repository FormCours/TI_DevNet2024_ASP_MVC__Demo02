using Demo_ASPMVC_02.DAL.Entities;

namespace Demo_ASPMVC_02.Models.Mapper
{
    public static class TypeMapper
    {
        public static PokemonType ToEntity(this TypeViewModel viewModel)
        {
            return new PokemonType
            {
                Id = viewModel.Id,
                Nom = viewModel.Nom
            };
        }
        public static PokemonType ToEntity(this TypeFormModel formModel)
        {
            return new PokemonType
            {
                Id = formModel.Id,
                Nom = formModel.Nom
            };
        }
        public static TypeViewModel ToViewModel(this PokemonType entity)
        {
            return new TypeViewModel
            {
                Id = entity.Id,
                Nom = entity.Nom
            };
        }
        public static TypeFormModel ToFormModel(this PokemonType entity)
        {
            return new TypeFormModel
            {
                Id = entity.Id,
                Nom = entity.Nom
            };
        }
    }
}
