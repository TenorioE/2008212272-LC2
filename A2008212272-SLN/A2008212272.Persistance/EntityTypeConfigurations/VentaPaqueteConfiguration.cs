using A2008212272.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance.EntityTypeConfigurations
{
    public class VentaPaqueteConfiguration : EntityTypeConfiguration<VentaPaquete>
    {

        public VentaPaqueteConfiguration()
        {
            ToTable("VentaPaquete");
            HasKey(c => c.VentaId);
        }

    }
}
