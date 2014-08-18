namespace RestManager.DataContexts.RestaurantMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            AddColumn("dbo.OrderItems", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderItems", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "DeliveryTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "DeliveredTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Delivered", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Paid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Customer_Id");
            AddForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            DropColumn("dbo.Orders", "Customer_Id");
            DropColumn("dbo.Orders", "Paid");
            DropColumn("dbo.Orders", "Delivered");
            DropColumn("dbo.Orders", "DeliveredTime");
            DropColumn("dbo.Orders", "DeliveryTime");
            DropColumn("dbo.OrderItems", "UnitPrice");
            DropColumn("dbo.OrderItems", "Discount");
            DropTable("dbo.Customers");
        }
    }
}
