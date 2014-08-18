using System.Data.Entity;
using RestManager.Models;

namespace RestManager.DataContexts
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}