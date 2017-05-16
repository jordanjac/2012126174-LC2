using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private readonly TransporteDbContext _Context;

        public BusRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private BusRepository()
        {

        }

        public IEnumerable<Bus> GetTripulacionByBus(Tripulacion tripulacion)
        {
            throw new NotImplementedException();
        }
    }
}
