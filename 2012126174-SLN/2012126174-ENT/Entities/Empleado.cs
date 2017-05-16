using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_ENT
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public long Codigo { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Correo { get; set; }

        public Empleado()
        {

        }

        public Empleado(long cod, string nom, string aPat, string aMat, string mail)
        {
            Codigo = cod;
            Nombre = nom;
            ApePaterno = aPat;
            ApeMaterno = aMat;
            Correo = mail;
        }

    }
}
