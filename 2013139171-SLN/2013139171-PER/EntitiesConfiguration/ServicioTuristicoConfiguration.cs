using _2013139171_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.EntitiesConfiguration
{
    public class ServicioTuristicoConfiguration : EntityTypeConfiguration<ServicioTuristico>
    {
        public ServicioTuristicoConfiguration()
        {
            ToTable("Servicios Turisticos");
            HasKey(c => c.ServicioTuristicoID);
            Property(c => c.nombre);

           //Paquete
            HasRequired(c => c.Paquete)
                    .WithMany(c => c.ServicioTuristico);
        }
    }
}
