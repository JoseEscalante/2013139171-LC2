using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT
{
    public class Hospedaje : ServicioTuristico
    {
        public int HospedajeID { get; set; }
        public string nombre { get; set; }
        
        //TipoHospedaje

        public TipoHospedaje TipoHospedaje { get; set; }
        public int TipoHospedajeID { get; set; }

        //CalificacionHospedaje

        public CalificacionHospedaje CalificacionHospedaje { get; set; }
        public int CalificacionHospedajeID { get; set; }

        //CategoriaHospedaje

        public CategoriaHospedaje CategoriaHospedaje { get; set; }
        public int CategoriaHospedajeID { get; set; }

        //ServicioHospedaje

        public ServicioHospedaje ServicioHospedaje { get; set; }
        public int ServicioHospedajeID { get; set; }

        //Inicializacion de las entidades
        public Hospedaje(TipoHospedaje tipohospedaje, CalificacionHospedaje calificacionhospedaje, CategoriaHospedaje categoriahospedaje, ServicioHospedaje serviciohospedaje)
        {
            TipoHospedaje = tipohospedaje;
            CalificacionHospedaje = calificacionhospedaje;
            CategoriaHospedaje = categoriahospedaje;
            ServicioHospedaje = serviciohospedaje;
        }






    }
}
