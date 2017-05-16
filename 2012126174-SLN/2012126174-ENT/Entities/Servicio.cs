using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public Servicio()
        {

        }

        public Servicio(string desc, double prec)
        {
            Descripcion = desc;
            Precio = prec;
        }



    }
}
