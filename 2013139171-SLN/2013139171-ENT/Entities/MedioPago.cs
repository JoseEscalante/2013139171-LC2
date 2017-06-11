using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class MedioPago
    {
        public int MedioPagoID { get; set; }
        public string nombre { get; set; }
        
        //VentaPaquete
        public List<VentaPaquete> VentaPaquete { get; set; }

        //Creacion de lista VentaPaquete
        public MedioPago()
        {
            VentaPaquete = new List<VentaPaquete>();
        }
      
    }
}
