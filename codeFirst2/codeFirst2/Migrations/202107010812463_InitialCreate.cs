namespace codeFirst2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        Urunid = c.Int(nullable: false, identity: true),
                        Urunad = c.String(),
                        UrunMarka = c.String(),
                        UrunKategori = c.String(),
                        UrunStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Urunid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
