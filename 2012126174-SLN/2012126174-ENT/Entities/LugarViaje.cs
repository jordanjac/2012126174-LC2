using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }
        public string Descripcion { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }

        public int EncomiendaId { get; set; }
        public Encomienda Encomienda { get; set; }

        public List<TipoLugar> TipoLugars { get; set; }

        public LugarViaje()
        {
            TipoLugars = new List<TipoLugar>();
        }
    }
}
