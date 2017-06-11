using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class ComprobantePago
    {
        public int ComprobantePagoID { get; set; }
        public string nombre { get; set; }
        

        public List<TipoComprobante> TipoComprobante { get; set; }

        public ComprobantePago()
        {
            TipoComprobante = new List<TipoComprobante>();
            VentaPaquete = new List<VentaPaquete>();
        }

        //VentaPaquete

        public List<VentaPaquete> VentaPaquete { get; set; }

        







    }
}
