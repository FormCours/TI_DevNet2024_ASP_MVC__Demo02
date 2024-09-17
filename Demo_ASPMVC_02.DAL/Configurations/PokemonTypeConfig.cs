using Demo_ASPMVC_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ASPMVC_02.DAL.Configurations
{
    public class PokemonTypeConfig : IEntityTypeConfiguration<PokemonType>
    {
        public void Configure(EntityTypeBuilder<PokemonType> builder)
        {
            // Table Pokemon
            builder.ToTable("PokemonType");

            //Colonnes
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.Nom)
                .HasMaxLength(100)
                .IsRequired();

            // Contrainte
            builder.HasKey(t => t.Id)
                    .HasName("PK_PokemonType");
        }
    }
}
