using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class Alimentacion : ServicioTuristico
    {
        public int AlimentacionID { get; set; }
        public string nombre { get; set; }
        //CategoriaAlimentacion
        public CategoriaAlimentacion CategoriaAlimentacion { set; get; }
        public int CategoriaAlimentacionID { get; set; }

        public Alimentacion()
        {

        }

        public Alimentacion(CategoriaAlimentacion categoriaalimentacion)
        {
            CategoriaAlimentacion = categoriaalimentacion;
        }

    }
}
