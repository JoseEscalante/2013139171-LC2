using _2013139171_ENT;
using _2013139171_PER.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER
{
   public class _2013139171DbContext : DbContext
      
    {
        public DbSet<Alimentacion> Alimentacions { get; set; }
        public DbSet<CalificacionHospedaje> CalificacionDeHospedaje { get; set; }
        public DbSet<CategoriaAlimentacion> CategoriaDeAlimentacion { get; set; }
        public DbSet<CategoriaHospedaje> CategoriaDeHospedaje { get; set; }
        public DbSet<CategoriaTransporte> CategoriaDeTransporte { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ComprobantePago> ComprobanteDePago { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hospedaje> Hospedajes { get; set; }
        public DbSet<MedioPago> MedioDePago { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<ServicioHospedaje> ServicioDeHospedaje { get; set; }
        public DbSet<ServicioTuristico> ServicioTuristicos { get; set; }
        public DbSet<TipoComprobante> TipoDeComprobante { get; set; }
        public DbSet<TipoHospedaje> TipoDeHospedaje { get; set; }
        public DbSet<TipoTransporte> TipoDeTransporte { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<VentaPaquete> VentaPaquetes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CalificacionHospedajeConfiguration());
            modelBuilder.Configurations.Add(new CategoriaAlimentacionConfiguration());
            modelBuilder.Configurations.Add(new CategoriaHospedajeConfiguration());
            modelBuilder.Configurations.Add(new CategoriaTrasnporteConfiguration());
            modelBuilder.Configurations.Add(new ComprobantePagoConfiguration());
            modelBuilder.Configurations.Add(new MedioPagoConfiguration());
            modelBuilder.Configurations.Add(new PaqueteConfiguration());
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new ServicioHospedajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioTuristicoConfiguration());
            modelBuilder.Configurations.Add(new TipoComprobanteConfiguration());
            modelBuilder.Configurations.Add(new TipoHospedajeConfiguration());
            modelBuilder.Configurations.Add(new TipoTransporteConfiguration());
            modelBuilder.Configurations.Add(new VentaPaqueteConfiguration());

            Database.SetInitializer< _2013139171DbContext > (null);
            base.OnModelCreating(modelBuilder);
           

        }

        }
    }
