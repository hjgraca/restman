namespace RestManager.DataContexts.RestaurantMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate13 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderItems", "UnitPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
