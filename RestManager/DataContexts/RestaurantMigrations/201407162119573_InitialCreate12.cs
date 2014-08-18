namespace RestManager.DataContexts.RestaurantMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Order_Id", c => c.Int());
            AddColumn("dbo.Orders", "Restaurant_Id", c => c.Int());
            CreateIndex("dbo.OrderItems", "Order_Id");
            CreateIndex("dbo.Orders", "Restaurant_Id");
            AddForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.Orders", "Restaurant_Id", "dbo.Restaurants", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Restaurant_Id", "dbo.Restaurants");
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "Restaurant_Id" });
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropColumn("dbo.Orders", "Restaurant_Id");
            DropColumn("dbo.OrderItems", "Order_Id");
        }
    }
}
