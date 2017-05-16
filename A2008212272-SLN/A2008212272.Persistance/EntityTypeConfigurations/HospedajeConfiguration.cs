using A2008212272.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance.EntityTypeConfigurations
{
    public class HospedajeConfiguration : EntityTypeConfiguration<Hospedaje>
    {
        public HospedajeConfiguration()
        {
            ToTable("Hospedaje");
            HasKey(c => c.HospedajeId);

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Ubicacion)
                .IsRequired()
                .HasMaxLength(140);

        }

    }
}
