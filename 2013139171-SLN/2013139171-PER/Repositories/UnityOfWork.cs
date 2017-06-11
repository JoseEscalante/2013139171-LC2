using _2013139171_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2013139171DbContext _Context;
       

        public IAlimentacionRepository Alimentacion { get; private set; }
        public ICalificacionHospedajeRepository CalificacionHospedaje { get; private set; }
        public ICategoriaAlimentacionRepository CategoriaAlimentacion { get; private set; }
        public ICategoriaHospedajeRepository CategoriaHospedaje { get; private set; }
        public ICategoriaTransporteRepository CategoriaTransporte { get; private set; }
        public IClienteRepository Cliente { get; private set; }
        public IComprobantePagoRepository ComprobantePago { get; private set; }
        public IEmpleadoRepository Empleado { get; private set; }
        public IHospedajeRepository Hospedaje { get; private set; }
        public IMedioPagoRepository MedioPago { get; private set; }
        public IPaqueteRepository Paquete { get; private set; }
        public IPersonaRepository Persona { get; private set; }
        public IServicioHospedajeRepository ServicioHospedaje { get; private set; }
        public IServicioTuristicoRepository ServicioTuristico { get; private set; }
        public ITipoComprobanteRepository TipoComprobante { get; private set; }
        public ITipoHospedajeRepository TipoHospedaje { get; private set; }
        public ITipoTransporteRepository TipoTransporte { get; private set; }
        public ITransporteRepository Transporte { get; private set; }
        public IVentaPaqueteRepository VentaPaquete { get; private set; }

        //Se define el constructor por defecto como privado
        //para que  se fuerce a utilizar la propiedad instance 

        

        public UnityOfWork()
        {
            _Context = new _2013139171DbContext();

            Alimentacion = new AlimentacionRepository(_Context);
            CalificacionHospedaje = new CalificacionHospedajeRepository(_Context);
            CategoriaAlimentacion = new CategoriaAlimentacionRepository(_Context);
            CategoriaHospedaje = new CategoriaHospedajeRepository(_Context);
            CategoriaTransporte = new CategoriaTransporteRepository(_Context);
            Cliente = new ClienteRepository(_Context);
            ComprobantePago = new ComprobantePagoRepository(_Context);
            Empleado = new EmpleadoRepository(_Context);
            Hospedaje = new HospedajeRepository(_Context);
            MedioPago = new MedioPagoRepository(_Context);
            Paquete = new PaqueteRepository(_Context);
            Persona = new PersonaRepository(_Context);
            ServicioHospedaje = new ServicioHospedajeRepository(_Context);
            ServicioTuristico = new ServicioTuristicoRepository(_Context);
            TipoComprobante = new TipoComprobanteRepository(_Context);
            TipoHospedaje = new TipoHospedajeRepository(_Context);
            TipoTransporte = new TipoTransporteRepository(_Context);
            Transporte = new TransporteRepository(_Context);
            VentaPaquete = new VentaPaqueteRepository(_Context);

        }

        //Implementacion del patron singleton para instanciar la Clase UnityOfWork
        //COn este patron se asegura cualquier parte del codigo que se quiera
        //Instanciar  la base de datos, se devuelve una unica refeencia
       /*public static UnityOfWork Instance
        {
            get
            {
                //Variable de control para manejar el acceso concurrente
                //Al instanciamiento de la clase UnityOfWork
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }
       */ 
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }


    }
}
