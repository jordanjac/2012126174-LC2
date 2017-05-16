using _2012126174_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174_PER.EntitiesConfigurations
{
    public class ServicioConfiguration:EntityTypeConfiguration<Servicio>
    {

        public ServicioConfiguration()
        {
            ToTable("Servicio");
            HasKey(p => p.ServicioId);
            Property(p => p.Descripcion).IsRequired();
            Property(p => p.Precio).IsRequired();


            Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));
            Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));

        }

    }
}
