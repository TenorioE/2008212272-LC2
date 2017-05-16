using A2008212272.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance.EntityTypeConfigurations
{
    public class ComprobantePagoConfiguration : EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            ToTable("ComprobantePago");
            HasKey(c => c.ComprobanteId);

            Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(255);

        }

    }
}
