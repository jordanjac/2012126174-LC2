using _2012126174_ENT;
using _2012126174_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations.Repositories
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {
        private readonly TransporteDbContext _Context;

        public TransporteRepository(TransporteDbContext context)
        {
            _Context = context;
        }

        private TransporteRepository()
        {

        }

        public IEnumerable<Transporte> GetTransporteByBys(Bus bus)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> GetTransporteByCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> GetTransporteByLugarViaje(LugarViaje lugarviaje)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> GetTransporteByServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transporte> GetTransporteByTipoViaje(TipoViaje tipoviaje)
        {
            throw new NotImplementedException();
        }
    }
}
