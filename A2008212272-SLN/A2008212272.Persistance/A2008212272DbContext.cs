﻿using A2008212272.Entities;
using A2008212272.Persistance.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2008212272.Persistance
{
    public class A2008212272DbContext : DbContext
    {

        public DbSet<Alimentacion> Alimentaciones { get; set; }
        public DbSet<CalificacionHospedaje> CalificacionHospedajes { get; set; }
        public DbSet<CategoriaAlimentacion> CategoriaAlimentaciones { get; set; }
        public DbSet<CategoriaHospedaje> CategoriaHospedajes { get; set; }
        public DbSet<CategoriaTransporte> CategoriaTransportes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ComprobantePago> ComprobantePagos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hospedaje> Hospedajes { get; set; }
        public DbSet<MedioPago> MedioPagos { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<ServicioHospedaje> ServicioHospedajes { get; set; }
        public DbSet<ServicioTuristico> ServicioTuristicos { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoHospedaje> TipoHospedajes { get; set; }
        public DbSet<TipoTransporte> TipoTransportes { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<VentaPaquete> VentaPaquetes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlimentacionConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ComprobantePagoConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new HospedajeConfiguration());
            modelBuilder.Configurations.Add(new PaqueteConfiguration());
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new ServicioTuristicoConfiguration());
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new VentaPaqueteConfiguration());


            base.OnModelCreating(modelBuilder);

        }

    }
}
