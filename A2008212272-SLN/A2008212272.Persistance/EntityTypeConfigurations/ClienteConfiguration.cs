using A2008212272.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance.EntityTypeConfigurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");
            HasKey(c => c.ClienteId);

            Property(c => c.Direccion)
                .IsRequired()
                .HasMaxLength(140);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(50);
        }

    }
}
