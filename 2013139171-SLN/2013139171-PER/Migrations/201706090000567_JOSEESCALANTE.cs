namespace _2013139171_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JOSEESCALANTE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicios Turisticos",
                c => new
                    {
                        ServicioTuristicoID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        PaqueteID = c.Int(nullable: false),
                        AlimentacionID = c.Int(),
                        CategoriaAlimentacionID = c.Int(),
                        HospedajeID = c.Int(),
                        TipoHospedajeID = c.Int(),
                        CalificacionHospedajeID = c.Int(),
                        CategoriaHospedajeID = c.Int(),
                        ServicioHospedajeID = c.Int(),
                        TransporteID = c.Int(),
                        TipoTransporteID = c.Int(),
                        CategoriaTransporteID = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ServicioTuristicoID)
                .ForeignKey("dbo.Alimentacion", t => t.CategoriaAlimentacionID, cascadeDelete: true)
                .ForeignKey("dbo.Paquetes", t => t.PaqueteID, cascadeDelete: true)
                .ForeignKey("dbo.CalificacionHospedajes", t => t.CalificacionHospedajeID, cascadeDelete: true)
                .ForeignKey("dbo.CategoriaHospedajes", t => t.CategoriaHospedajeID, cascadeDelete: true)
                .ForeignKey("dbo.ServicioHospedajes", t => t.ServicioHospedajeID, cascadeDelete: true)
                .ForeignKey("dbo.TipoHospedajes", t => t.TipoHospedajeID, cascadeDelete: true)
                .ForeignKey("dbo.CategoriaTransportes", t => t.CategoriaTransporteID, cascadeDelete: true)
                .ForeignKey("dbo.TipoTransportes", t => t.TipoTransporteID, cascadeDelete: true)
                .Index(t => t.PaqueteID)
                .Index(t => t.CategoriaAlimentacionID)
                .Index(t => t.TipoHospedajeID)
                .Index(t => t.CalificacionHospedajeID)
                .Index(t => t.CategoriaHospedajeID)
                .Index(t => t.ServicioHospedajeID)
                .Index(t => t.TipoTransporteID)
                .Index(t => t.CategoriaTransporteID);
            
            CreateTable(
                "dbo.Alimentacion",
                c => new
                    {
                        CategoriaAlimentacionID = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.CategoriaAlimentacionID);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        PaqueteID = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.PaqueteID);
            
            CreateTable(
                "dbo.CalificacionHospedajes",
                c => new
                    {
                        CalificacionHospedajeID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.CalificacionHospedajeID);
            
            CreateTable(
                "dbo.CategoriaHospedajes",
                c => new
                    {
                        CategoriaHospedajeID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaHospedajeID);
            
            CreateTable(
                "dbo.ServicioHospedajes",
                c => new
                    {
                        ServicioHospedajeID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.ServicioHospedajeID);
            
            CreateTable(
                "dbo.TipoHospedajes",
                c => new
                    {
                        tipoHospedajeID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.tipoHospedajeID);
            
            CreateTable(
                "dbo.CategoriaTransportes",
                c => new
                    {
                        CategoriaTransporteID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaTransporteID);
            
            CreateTable(
                "dbo.TipoTransportes",
                c => new
                    {
                        TipoTransporteID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoTransporteID);
            
            CreateTable(
                "dbo.Venta de Paquetes",
                c => new
                    {
                        VentaPaqueteID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        MedioPagoID = c.Int(nullable: false),
                        ComprobantePagoID = c.Int(nullable: false),
                        PaqueteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaPaqueteID)
                .ForeignKey("dbo.ComprobantePagos", t => t.ComprobantePagoID, cascadeDelete: true)
                .ForeignKey("dbo.Medio de Pago", t => t.MedioPagoID, cascadeDelete: true)
                .ForeignKey("dbo.Paquetes", t => t.PaqueteId, cascadeDelete: true)
                .Index(t => t.MedioPagoID)
                .Index(t => t.ComprobantePagoID)
                .Index(t => t.PaqueteId);
            
            CreateTable(
                "dbo.ComprobantePagos",
                c => new
                    {
                        ComprobantePagoID = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ComprobantePagoID);
            
            CreateTable(
                "dbo.TiposComprobantes",
                c => new
                    {
                        TipoComprobanteID = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.TipoComprobanteID);
            
            CreateTable(
                "dbo.Medio de Pago",
                c => new
                    {
                        MedioPagoID = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.MedioPagoID);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        ClienteID = c.Int(),
                        EmpleadoID = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonaID);
            
            CreateTable(
                "dbo.TipoComprobanteComprobantePagoes",
                c => new
                    {
                        TipoComprobante_TipoComprobanteID = c.Int(nullable: false),
                        ComprobantePago_ComprobantePagoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TipoComprobante_TipoComprobanteID, t.ComprobantePago_ComprobantePagoID })
                .ForeignKey("dbo.TiposComprobantes", t => t.TipoComprobante_TipoComprobanteID, cascadeDelete: true)
                .ForeignKey("dbo.ComprobantePagos", t => t.ComprobantePago_ComprobantePagoID, cascadeDelete: true)
                .Index(t => t.TipoComprobante_TipoComprobanteID)
                .Index(t => t.ComprobantePago_ComprobantePagoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta de Paquetes", "PaqueteId", "dbo.Paquetes");
            DropForeignKey("dbo.Venta de Paquetes", "MedioPagoID", "dbo.Medio de Pago");
            DropForeignKey("dbo.Venta de Paquetes", "ComprobantePagoID", "dbo.ComprobantePagos");
            DropForeignKey("dbo.TipoComprobanteComprobantePagoes", "ComprobantePago_ComprobantePagoID", "dbo.ComprobantePagos");
            DropForeignKey("dbo.TipoComprobanteComprobantePagoes", "TipoComprobante_TipoComprobanteID", "dbo.TiposComprobantes");
            DropForeignKey("dbo.Servicios Turisticos", "TipoTransporteID", "dbo.TipoTransportes");
            DropForeignKey("dbo.Servicios Turisticos", "CategoriaTransporteID", "dbo.CategoriaTransportes");
            DropForeignKey("dbo.Servicios Turisticos", "TipoHospedajeID", "dbo.TipoHospedajes");
            DropForeignKey("dbo.Servicios Turisticos", "ServicioHospedajeID", "dbo.ServicioHospedajes");
            DropForeignKey("dbo.Servicios Turisticos", "CategoriaHospedajeID", "dbo.CategoriaHospedajes");
            DropForeignKey("dbo.Servicios Turisticos", "CalificacionHospedajeID", "dbo.CalificacionHospedajes");
            DropForeignKey("dbo.Servicios Turisticos", "PaqueteID", "dbo.Paquetes");
            DropForeignKey("dbo.Servicios Turisticos", "CategoriaAlimentacionID", "dbo.Alimentacion");
            DropIndex("dbo.TipoComprobanteComprobantePagoes", new[] { "ComprobantePago_ComprobantePagoID" });
            DropIndex("dbo.TipoComprobanteComprobantePagoes", new[] { "TipoComprobante_TipoComprobanteID" });
            DropIndex("dbo.Venta de Paquetes", new[] { "PaqueteId" });
            DropIndex("dbo.Venta de Paquetes", new[] { "ComprobantePagoID" });
            DropIndex("dbo.Venta de Paquetes", new[] { "MedioPagoID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "CategoriaTransporteID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "TipoTransporteID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "ServicioHospedajeID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "CategoriaHospedajeID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "CalificacionHospedajeID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "TipoHospedajeID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "CategoriaAlimentacionID" });
            DropIndex("dbo.Servicios Turisticos", new[] { "PaqueteID" });
            DropTable("dbo.TipoComprobanteComprobantePagoes");
            DropTable("dbo.Personas");
            DropTable("dbo.Medio de Pago");
            DropTable("dbo.TiposComprobantes");
            DropTable("dbo.ComprobantePagos");
            DropTable("dbo.Venta de Paquetes");
            DropTable("dbo.TipoTransportes");
            DropTable("dbo.CategoriaTransportes");
            DropTable("dbo.TipoHospedajes");
            DropTable("dbo.ServicioHospedajes");
            DropTable("dbo.CategoriaHospedajes");
            DropTable("dbo.CalificacionHospedajes");
            DropTable("dbo.Paquetes");
            DropTable("dbo.Alimentacion");
            DropTable("dbo.Servicios Turisticos");
        }
    }
}
