using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public abstract class ServicioTuristico
    {
        public int ServicioTuristicoID { get; set; }
        public string nombre { get; set; }

        //Paquete
        public int PaqueteID { get; set; }
        public Paquete Paquete { get; set; }




    }
}
