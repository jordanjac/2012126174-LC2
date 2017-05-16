using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly TransporteDbContext _Context;

        public ClienteRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private ClienteRepository()
        {

        }

        public IEnumerable<Cliente> GetClienteWithVenta(int vent)
        {
            throw new NotImplementedException();
        }
    }
}
