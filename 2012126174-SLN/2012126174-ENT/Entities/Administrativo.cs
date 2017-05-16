using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Administrativo : Empleado
    {
        public int AdministrativoId { get; set; }
        public string Turno { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public Administrativo()
        {
               
        }

        public Administrativo(long cod, string nom, string aPat, string aMat, string mail):base(cod,nom,aPat,aMat,mail)
        {

        }
    }
}
