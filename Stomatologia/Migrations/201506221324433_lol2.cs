namespace Stomatologia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wizytas", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wizytas", "Data", c => c.String(nullable: false));
        }
    }
}
