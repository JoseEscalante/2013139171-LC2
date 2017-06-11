using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class Paquete
    {
        public  int PaqueteID { get; set; }
        public string nombre { get; set; }


        //Servicio Turistico
        public List<ServicioTuristico> ServicioTuristico { get; set; }

        //VentaPaquetes
        public List<VentaPaquete>VentaPaquetes { get; set; }

        public Paquete()
        {
            ServicioTuristico = new List<ServicioTuristico>();
            VentaPaquetes = new List<VentaPaquete>();

        }

        
    }
}
