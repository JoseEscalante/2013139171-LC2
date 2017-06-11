using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class CategoriaHospedaje
    {
       
        public int CategoriaHospedajeID { get; set; }
        public string nombre { get; set; }

        //Hospedaje

        public List<Hospedaje> Hospedaje { get; set; }

        //Creacion de la lista de Hospedaje
        public CategoriaHospedaje()
        {
            Hospedaje = new List<Hospedaje>();
        }
    }
}
