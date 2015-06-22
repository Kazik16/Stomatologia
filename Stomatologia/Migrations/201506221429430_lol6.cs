namespace Stomatologia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Wizytas", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Wizytas", "Data", c => c.DateTime(nullable: false));
        }
    }
}
