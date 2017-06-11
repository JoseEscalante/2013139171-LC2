using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class VentaPaquete
    {
        public int VentaPaqueteID { get; set; }
        public string nombre { get; set; }

        //MedioPago
        public MedioPago MedioPago { get; set; }
        public int MedioPagoID { get; set; }

        //Comprobante de Pago
        public ComprobantePago ComprobantePago { get; set; }
        public int ComprobantePagoID { get; set; }
        //Paquete
        public int PaqueteId { get; set; }
        public Paquete Paquete { get; set; }

        public VentaPaquete()
        {

        }

        public VentaPaquete(Paquete paquete, ComprobantePago comprobantepago)
        {
            Paquete = paquete;
            ComprobantePago = comprobantepago;
        }
        

       




        






    }
}
