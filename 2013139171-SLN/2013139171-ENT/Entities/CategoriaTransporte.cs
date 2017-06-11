using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class CategoriaTransporte
    {
        
        public int CategoriaTransporteID { get; set; }
        public string nombre { get; set; }

        //Transporte

        public List<Transporte> Transporte { get; set; }

        //Creacion de la lista de Transporte
        public CategoriaTransporte()
        {
            Transporte = new List<Transporte>();
        }
    }
}
