using _2012126174_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations
{
    public class EmpleadoConfiguration:EntityTypeConfiguration<Empleado>
    {
     
        public EmpleadoConfiguration()
        {
            ToTable("Empleado");
            HasKey(p => p.EmpleadoId);
            Property(p => p.Codigo).IsRequired();
            Property(p => p.Nombre).IsRequired();
            Property(p => p.ApePaterno).IsRequired();
            Property(p => p.ApeMaterno).IsRequired();
            Property(p => p.Correo).IsRequired();


            Map<Administrativo>(m => m.Requires("Discriminator").HasValue("Administrativo"));
            Map<Tripulacion>(m => m.Requires("Discriminator").HasValue("Tripulacion"));

        }



    }
}
