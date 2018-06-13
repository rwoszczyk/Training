namespace Store.Entities.Mgr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Details", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Details");
        }
    }
}
