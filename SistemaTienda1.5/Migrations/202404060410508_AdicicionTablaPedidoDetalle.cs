namespace SistemaTienda1._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicicionTablaPedidoDetalle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PedidoDetalle",
                c => new
                    {
                        PedidoDetalleId = c.Int(nullable: false, identity: true),
                        PedidoId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoDetalleId);
            
            DropTable("dbo.Pedido");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaPedido = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoId);
            
            DropTable("dbo.PedidoDetalle");
        }
    }
}
