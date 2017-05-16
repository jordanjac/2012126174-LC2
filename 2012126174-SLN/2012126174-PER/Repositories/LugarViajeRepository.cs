using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {
        private readonly TransporteDbContext _Context;

        public LugarViajeRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private LugarViajeRepository()
        {

        }

        public IEnumerable<LugarViaje> GetLugarviajeByTipoLugar(TipoLugar tipolguar)
        {
            throw new NotImplementedException();
        }
    }
}
