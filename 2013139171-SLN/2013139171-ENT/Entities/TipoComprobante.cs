using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class TipoComprobante
    {
        public int TipoComprobanteID { get; set; }
        public string nombre { get; set; }

        //ComprobantePago

        public List<ComprobantePago> ComprobantePago{ get; set; }

        //Creacion de la lista de Hospedaje
        public TipoComprobante()
        {
            ComprobantePago = new List<ComprobantePago>();
        }

    }
}
