using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        //Cada una de las propiedades deben ser lecturas
        IAlimentacionRepository Alimentacion { get; }
        ICalificacionHospedajeRepository CalificacionHospedaje { get; }
        ICategoriaAlimentacionRepository CategoriaAlimentacion { get; }
        ICategoriaHospedajeRepository CategoriaHospedaje { get; }
        ICategoriaTransporteRepository CategoriaTransporte { get; }
        IClienteRepository Cliente { get;  }
        IComprobantePagoRepository ComprobantePago { get; }
        IEmpleadoRepository Empleado { get; }
        IHospedajeRepository Hospedaje { get; }
        IMedioPagoRepository MedioPago { get; }
        IPaqueteRepository Paquete { get; }
        IPersonaRepository Persona { get;  }
        IServicioHospedajeRepository ServicioHospedaje { get; }
        IServicioTuristicoRepository ServicioTuristico { get; }
        ITipoComprobanteRepository TipoComprobante { get; }
        ITipoHospedajeRepository TipoHospedaje { get; }
        ITipoTransporteRepository TipoTransporte { get; }
        ITransporteRepository Transporte { get; }
        IVentaPaqueteRepository VentaPaquete { get; }


        //Metodo para guardar los cambios en la base de datos
        int SaveChanges();

        void StateModified(object entity);



    }
}
