using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buss { get;  }
        IClienteRepository Clientes { get;  }
        IEmpleadoRepository Empleados { get;  }
        IEncomiendaRepository Encomiendas { get;  }
        ILugarViajeRepository LugarViajes { get;  }
        IServicioRepository Servicios { get;  }
        ITipoComprobanteRepository TipoComprobantes { get;  }
        ITipoLugarRepository TipoLugars { get;  }
        ITipoPagoRepository TipoPagos { get;  }
        ITipoTripulacionRepository TipoTripulacions { get;  }
        ITipoViajeRepository TipoViajes { get;  }
        ITransporteRepository Transportes { get;  }
        ITripulacionRepository Tripulacions { get;  }
        IVentaRepository Ventas { get;  }

        int SaveChanges();
    }
}
