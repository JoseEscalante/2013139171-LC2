using _2013139171_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.EntitiesConfiguration
{
    public class VentaPaqueteConfiguration : EntityTypeConfiguration<VentaPaquete> 
    {
        public VentaPaqueteConfiguration()
        {
            //tabla
            ToTable("Venta de Paquetes");
            HasKey(a => a.VentaPaqueteID);
            Property(a => a.nombre);


            //Relaciones MedioPago
            HasRequired(a => a.MedioPago)
                .WithMany(b => b.VentaPaquete)
                .HasForeignKey(b => b.MedioPagoID);

            //Relaciones ComprobantePago
            HasRequired(a => a.ComprobantePago)
                .WithMany(b => b.VentaPaquete)
                .HasForeignKey(b => b.ComprobantePagoID);





        }
           
    }
}
