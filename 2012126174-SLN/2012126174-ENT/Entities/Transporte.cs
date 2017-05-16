using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Transporte : Servicio
    {
        public int TransporteId { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public List<Cliente> Clientes { get; set; }
        public List<TipoViaje> TipoViajes { get; set; }
        public List<LugarViaje> LugarViajes { get; set; }

        private List<Bus> _Buss;
        public List<Bus> Buss { get; set; }

        public Transporte()
        {

        }

        public Transporte(List<Bus> buss, string desc, double prec):base(desc,prec)
        {
            Clientes = new List<Cliente>();
            TipoViajes = new List<TipoViaje>();
            LugarViajes = new List<LugarViaje>();
            Buss = buss;
        }
    }
}
