namespace ExamenArellanoBedonBenavidesCoronelSevillanoToapanta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armaduras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreArmadura = c.String(nullable: false),
                        Tipo = c.String(),
                        Resistencia = c.Int(nullable: false),
                        CaballeroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Caballeroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Constelacion = c.String(),
                        NivelPoder = c.Int(nullable: false),
                        Elemento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CaballeroArmaduras",
                c => new
                    {
                        Caballero_Id = c.Int(nullable: false),
                        Armadura_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Caballero_Id, t.Armadura_Id })
                .ForeignKey("dbo.Caballeroes", t => t.Caballero_Id, cascadeDelete: true)
                .ForeignKey("dbo.Armaduras", t => t.Armadura_Id, cascadeDelete: true)
                .Index(t => t.Caballero_Id)
                .Index(t => t.Armadura_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CaballeroArmaduras", "Armadura_Id", "dbo.Armaduras");
            DropForeignKey("dbo.CaballeroArmaduras", "Caballero_Id", "dbo.Caballeroes");
            DropIndex("dbo.CaballeroArmaduras", new[] { "Armadura_Id" });
            DropIndex("dbo.CaballeroArmaduras", new[] { "Caballero_Id" });
            DropTable("dbo.CaballeroArmaduras");
            DropTable("dbo.Caballeroes");
            DropTable("dbo.Armaduras");
        }
    }
}
