using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Tripulacion : Empleado
    {
        public int TripulacionId { get; set; }
        public string Cargo { get; set; }

        public List<TipoTripulacion> TipoTripulacions { get; set; }


        public Tripulacion()
        {

        }

        public Tripulacion(long cod, string nom, string aPat, string aMat, string mail) : base(cod, nom, aPat, aMat, mail)
        {
            TipoTripulacions = new List<TipoTripulacion>();
        }

      
    }
}
