using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class TipoViaje
    {
        public int TipoViajeId { get; set; }
        public string Descripcion { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }
    }
}
