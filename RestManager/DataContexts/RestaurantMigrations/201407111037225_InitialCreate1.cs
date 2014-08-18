namespace RestManager.DataContexts.RestaurantMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "RestaurantKey", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "RestaurantKey");
        }
    }
}
