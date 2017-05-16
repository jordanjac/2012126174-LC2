namespace _2012126174_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(),
                        ApePaterno = c.String(),
                        ApeMaterno = c.String(),
                        Correo = c.String(),
                        AdministrativoId = c.Int(),
                        Turno = c.String(),
                        VentaId = c.Int(),
                        TripulacionId = c.Int(),
                        Cargo = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Bus_BusId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .ForeignKey("dbo.Buses", t => t.Bus_BusId)
                .Index(t => t.VentaId)
                .Index(t => t.Bus_BusId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VentaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApePaterno = c.String(),
                        ApeMaterno = c.String(),
                        VentaId = c.Int(nullable: false),
                        TransporteId = c.Int(nullable: false),
                        Transporte_ServicioId = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        ServicioId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Precio = c.Double(nullable: false),
                        VentaId = c.Int(nullable: false),
                        TransporteId = c.Int(),
                        Estado = c.String(),
                        EncomiendaId = c.Int(),
                        Distancia = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Bus_BusId = c.Int(),
                    })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Buses", t => t.Bus_BusId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.Bus_BusId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        Modelo = c.String(),
                        Transporte_ServicioId = c.Int(),
                    })
                .PrimaryKey(t => t.BusId)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.TipoTripulacions",
                c => new
                    {
                        TipoTripulacionId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TripulacionId = c.Int(nullable: false),
                        Tripulacion_EmpleadoId = c.Int(),
                    })
                .PrimaryKey(t => t.TipoTripulacionId)
                .ForeignKey("dbo.Empleadoes", t => t.Tripulacion_EmpleadoId)
                .Index(t => t.Tripulacion_EmpleadoId);
            
            CreateTable(
                "dbo.LugarViajes",
                c => new
                    {
                        LugarViajeId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TransporteId = c.Int(nullable: false),
                        EncomiendaId = c.Int(nullable: false),
                        Encomienda_ServicioId = c.Int(),
                        Transporte_ServicioId = c.Int(),
                    })
                .PrimaryKey(t => t.LugarViajeId)
                .ForeignKey("dbo.Servicios", t => t.Encomienda_ServicioId)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioId)
                .Index(t => t.Encomienda_ServicioId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.TipoLugars",
                c => new
                    {
                        TipoLugarId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        LugarViajeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoLugarId)
                .ForeignKey("dbo.LugarViajes", t => t.LugarViajeId, cascadeDelete: true)
                .Index(t => t.LugarViajeId);
            
            CreateTable(
                "dbo.TipoViajes",
                c => new
                    {
                        TipoViajeId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        TransporteId = c.Int(nullable: false),
                        Transporte_ServicioId = c.Int(),
                    })
                .PrimaryKey(t => t.TipoViajeId)
                .ForeignKey("dbo.Servicios", t => t.Transporte_ServicioId)
                .Index(t => t.Transporte_ServicioId);
            
            CreateTable(
                "dbo.TipoComprobantes",
                c => new
                    {
                        TipoComprobanteId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoComprobanteId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoPagoId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoPagoes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.TipoComprobantes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Servicios", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Clientes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.TipoViajes", "Transporte_ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.LugarViajes", "Transporte_ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.TipoLugars", "LugarViajeId", "dbo.LugarViajes");
            DropForeignKey("dbo.LugarViajes", "Encomienda_ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.Servicios", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.Clientes", "Transporte_ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.Buses", "Transporte_ServicioId", "dbo.Servicios");
            DropForeignKey("dbo.Empleadoes", "Bus_BusId", "dbo.Buses");
            DropForeignKey("dbo.TipoTripulacions", "Tripulacion_EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.Empleadoes", "VentaId", "dbo.Ventas");
            DropIndex("dbo.TipoPagoes", new[] { "VentaId" });
            DropIndex("dbo.TipoComprobantes", new[] { "VentaId" });
            DropIndex("dbo.TipoViajes", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.TipoLugars", new[] { "LugarViajeId" });
            DropIndex("dbo.LugarViajes", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.LugarViajes", new[] { "Encomienda_ServicioId" });
            DropIndex("dbo.TipoTripulacions", new[] { "Tripulacion_EmpleadoId" });
            DropIndex("dbo.Buses", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.Servicios", new[] { "Bus_BusId" });
            DropIndex("dbo.Servicios", new[] { "VentaId" });
            DropIndex("dbo.Clientes", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.Clientes", new[] { "VentaId" });
            DropIndex("dbo.Empleadoes", new[] { "Bus_BusId" });
            DropIndex("dbo.Empleadoes", new[] { "VentaId" });
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoComprobantes");
            DropTable("dbo.TipoViajes");
            DropTable("dbo.TipoLugars");
            DropTable("dbo.LugarViajes");
            DropTable("dbo.TipoTripulacions");
            DropTable("dbo.Buses");
            DropTable("dbo.Servicios");
            DropTable("dbo.Clientes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Empleadoes");
        }
    }
}
