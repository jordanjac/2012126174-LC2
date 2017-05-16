using _2012126174_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012126174_ENT.Entities.IRepositories;
using _2012126174_PER.EntitiesConfigurations.Repositories;

namespace _2012126174_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private TransporteDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAdministrativoRepository Administrativos { get; private set; }
        public IBusRepository Buss { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IEmpleadoRepository Empleados { get; private set; }
        public IEncomiendaRepository Encomiendas { get; private set; }
        public ILugarViajeRepository LugarViajes { get; private set; }  
        public IServicioRepository Servicios { get; private set; }
        public ITipoComprobanteRepository TipoComprobantes { get; private set; }
        public ITipoLugarRepository TipoLugars { get; private set; }
        public ITipoPagoRepository TipoPagos { get; private set; }
        public ITipoTripulacionRepository TipoTripulacions { get; private set; }
        public ITipoViajeRepository TipoViajes { get; private set; }
        public ITransporteRepository Transportes { get; private set; }
        public ITripulacionRepository Tripulacions { get; private set; }
        public IVentaRepository Ventas { get; private set; }



        private UnityOfWork()
        {
            _Context = new TransporteDbContext();
            Administrativos = new AdministrativoRepository(_Context);
            Buss = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Empleados=new EmpleadoRepository(_Context);
            Encomiendas=new EncomiendaRepository(_Context);
            LugarViajes=new LugarViajeRepository(_Context);
            Servicios=new ServicioRepository(_Context);
            TipoComprobantes=new TipoComprobanteRepository(_Context);
            TipoLugars=new TipoLugarRepository(_Context);
            TipoPagos=new TipoPagoRepository(_Context);
            TipoTripulacions=new TipoTripulacionRepository(_Context);
            TipoViajes=new TipoViajeRepository(_Context);
            Transportes=new TransporteRepository(_Context);
            Tripulacions=new TripulacionRepository(_Context);
            Ventas=new VentaRepository(_Context);
        }

    
        public static UnityOfWork Instance
        {
            get
            {
               lock(_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }
                return _Instance;
            }
        }



       public  void Dispose()
        {
            _Context.Dispose();
        }

       public   int SaveChanges()
        {
            return _Context.SaveChanges();
        }
    }
}
