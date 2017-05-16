using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }

        private List<Tripulacion> _Tripulacions;
        public List<Tripulacion> Tripulacions { get; set; }

        public Bus(List<Tripulacion> tripulacions)
        {
            Tripulacions = tripulacions;
        }



    }
}
