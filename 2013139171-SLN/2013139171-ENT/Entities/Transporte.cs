using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class Transporte : ServicioTuristico
    {
        public int TransporteID { get; set; }
        public string nombre { get; set; }


        //TipoTransporte
        public TipoTransporte TipoTransporte { get; set; }
        public int TipoTransporteID { get; set; }

        //CategoriaTransporte
        public CategoriaTransporte CategoriaTransporte { get; set; }
        public int CategoriaTransporteID { get; set; }

        public Transporte()
        {

        }

        public Transporte(TipoTransporte tipotransporte, CategoriaTransporte categoriatransporte)
        {
            TipoTransporte = tipotransporte;
            CategoriaTransporte = categoriatransporte;
        }

    }
}
