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
    public class PokemonConfig: IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            // Table Pokemon
            builder.ToTable("Pokemon");

            //Colonnes
            builder.Property(p => p.Numero)
                .IsRequired();

            builder.Property(p => p.Nom)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Vie)
                .IsRequired();


            // Contrainte
            builder.HasKey(p => p.Numero)
                    .HasName("PK_Pokemon");

            // Relations
            builder.HasOne(p => p.Type1)
                .WithMany()
                .IsRequired();

            builder.HasOne(p => p.Type2)
                .WithMany();

            builder.HasOne(p => p.PreEvolution)
                .WithOne();


        }
    }
}
