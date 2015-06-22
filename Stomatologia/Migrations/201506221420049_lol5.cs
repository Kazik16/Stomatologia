namespace Stomatologia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wizytas", "LekarzId", c => c.String());
            AlterColumn("dbo.Wizytas", "PacjentId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wizytas", "PacjentId", c => c.String(nullable: false));
            AlterColumn("dbo.Wizytas", "LekarzId", c => c.String(nullable: false));
        }
    }
}
