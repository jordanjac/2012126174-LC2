using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class TipoTripulacionRepository : Repository<TipoTripulacion>, ITipoTripulacionRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoTripulacionRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoTripulacionRepository()
        {

        }

        public IEnumerable<TipoTripulacion> GetTipoTripulacionByTripulacion(Tripulacion tripulacion)
        {
            throw new NotImplementedException();
        }
    }
}
