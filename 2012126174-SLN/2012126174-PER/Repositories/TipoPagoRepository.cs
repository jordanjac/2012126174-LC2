using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class TipoPagoRepository : Repository<TipoPago>, ITipoPagoRepository
    {
        private readonly TransporteDbContext _Context;

        public TipoPagoRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TipoPagoRepository()
        {

        }

        public IEnumerable<TipoPago> GetTipoPagoByVenta(int venta)
        {
            throw new NotImplementedException();
        }
    }
}
