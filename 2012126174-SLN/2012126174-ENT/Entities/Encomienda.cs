using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Encomienda : Servicio
    {
        public int EncomiendaId { get; set; }
        public long Codigo { get; set; }
        public string Remitente { get; set; }
        public string Destinatario { get; set; }

        public List<LugarViaje> LugarViajes { get; set; }

        public Bus Bus { get; set; }

        public Encomienda()
        {
                
        }

        public Encomienda(string desc, double prec, Bus bus) : base(desc, prec)
        {
            LugarViajes = new List<LugarViaje>();
            Bus = bus;
        }
    }
}
