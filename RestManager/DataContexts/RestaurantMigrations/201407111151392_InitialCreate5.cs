namespace RestManager.DataContexts.RestaurantMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Order_Id", c => c.Int());
            CreateIndex("dbo.OrderItems", "Order_Id");
            AddForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropColumn("dbo.OrderItems", "Order_Id");
        }
    }
}
