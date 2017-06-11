using _2013139171_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.EntitiesConfiguration
{
    public class TipoComprobanteConfiguration : EntityTypeConfiguration<TipoComprobante>
    {
        public TipoComprobanteConfiguration()
        {
            //Configuracion de la tabla
            ToTable("TiposComprobantes");

            HasKey(a => a.TipoComprobanteID);

            Property(c => c.nombre).HasMaxLength(255);

            //Relacionando configuraciones 

            /* HasRequired(a => a.ComprobantePago)
                .WithMany(a => a.TipoComprobante);
                */

            




        }
    }
}
