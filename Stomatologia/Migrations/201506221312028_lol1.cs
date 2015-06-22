namespace Stomatologia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Wizytas");
            AlterColumn("dbo.Wizytas", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Wizytas", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Wizytas");
            AlterColumn("dbo.Wizytas", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Wizytas", "Id");
        }
    }
}
