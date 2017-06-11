using _2013139171_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.EntitiesConfiguration
{
   public class ComprobantePagoConfiguration : EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            //Configuracion de la tabla
            ToTable("ComprobantePagos");

            HasKey(a => a.ComprobantePagoID);

            Property(a => a.nombre).HasMaxLength(255);


           /* HasKey(c => c.VentaPaquete);

            Property(c => c.nombre).HasMaxLength(255);

            HasRequired(c => c.VentaPaquete)
                .WithMany(c => c.ComprobantePago);
                */
       
        }
    }
}
