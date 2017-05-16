using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoLugarRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoLugarRepository()
        {
                
        }

        public IEnumerable<TipoLugar> GetTipoLugarWithLugarviaje(int lugarviaje)
        {
            throw new NotImplementedException();
        }
    }
}
