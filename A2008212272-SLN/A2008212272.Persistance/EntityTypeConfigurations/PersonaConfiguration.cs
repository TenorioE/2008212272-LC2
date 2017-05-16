using A2008212272.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance.EntityTypeConfigurations
{
    public class PersonaConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            ToTable("Persona");
            HasKey(c => c.PersonaId);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.ApePat)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.ApeMat)
                .IsRequired()
                .HasMaxLength(50);

           

        }

    }
}
