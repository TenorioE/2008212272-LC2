using A2008212272.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance.EntityTypeConfigurations
{
    public class ServicioTuristicoConfiguration : EntityTypeConfiguration<ServicioTuristico>
    {
        public ServicioTuristicoConfiguration()
        {
            ToTable("ServicioTuristico");
            HasKey(c => c.ServicioId);

            Property(c => c.Comentario)
                .IsRequired()
                .HasMaxLength(140);

        }

    }
}
