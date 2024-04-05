namespace SistemaTienda1._5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddicionTablaCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 50),
                        Descripcion = c.String(maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categoria");
        }
    }
}
