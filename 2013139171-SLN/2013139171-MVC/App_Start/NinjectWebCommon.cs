[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(_2013139171_MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(_2013139171_MVC.App_Start.NinjectWebCommon), "Stop")]

namespace _2013139171_MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using _2013139171_ENT.IRepositories;
    using _2013139171_ENT;
    using _2013139171_PER.Repositories;
    using System.Data.Entity;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<_2013139171DbContext>(). To<_2013139171DbContext>();

            kernel.Bind<IAlimentacionRepository>().To<AlimentacionRepository>();
            kernel.Bind<ICalificacionHospedajeRepository>().To<CalificacionHospedajeRepository>();
            kernel.Bind<ICategoriaAlimentacionRepository>().To<CategoriaAlimentacionRepository>();
            kernel.Bind<ICategoriaHospedajeRepository>().To<CategoriaHospedajeRepository>();
            kernel.Bind<ICategoriaTransporteRepository>().To<CategoriaTransporteRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IComprobantePagoRepository>().To<ComprobantePagoRepository>();
            kernel.Bind<IEmpleadoRepository>().To<EmpleadoRepository>();
            kernel.Bind<IPaqueteRepository>().To<PaqueteRepository>();
            kernel.Bind<IPersonaRepository>().To<PersonaRepository>();
            kernel.Bind<IServicioHospedajeRepository>().To<ServicioHospedajeRepository>();
            kernel.Bind<IServicioTuristicoRepository>().To<ServicioTuristicoRepository>();
            kernel.Bind<ITipoComprobanteRepository>().To<TipoComprobanteRepository>();
            kernel.Bind<ITransporteRepository>().To<TransporteRepository>();
            kernel.Bind<IVentaPaqueteRepository>().To<VentaPaqueteRepository>();



        }        
    }
}
