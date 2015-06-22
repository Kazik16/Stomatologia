namespace Stomatologia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wizytas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        LekarzId = c.String(nullable: false),
                        PacjentId = c.String(nullable: false),
                        Data = c.String(nullable: false),
                        Hour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wizytas");
        }
    }
}
