using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012126174_ENT;
using System.Data.Entity;
using _2012126174_PER.EntitiesConfigurations;

namespace _2012126174_PER
{
    public class TransporteDbContext : DbContext
    {
        public DbSet<Administrativo> administrativos { get; set; }
        public DbSet<Bus> Buss { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Encomienda> Encomiendas { get; set; }
        public DbSet<LugarViaje> LugarViajes { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoLugar> TipoLugars { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoTripulacion> TipoTripulacions { get; set; }
        public DbSet<TipoViaje> TipoViajes { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<Tripulacion> Tripulacions { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministrativoConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new EncomiendaConfiguration());
            modelBuilder.Configurations.Add(new LugarViajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new TipoComprobanteConfiguration());
            modelBuilder.Configurations.Add(new TipoLugarConfiguration());
            modelBuilder.Configurations.Add(new TipoPagoConfiguration());
            modelBuilder.Configurations.Add(new TipoTripulacionConfiguration());
            modelBuilder.Configurations.Add(new TipoViajeConfiguration());
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new TripulacionConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());



            base.OnModelCreating(modelBuilder);
        }
    }
}
