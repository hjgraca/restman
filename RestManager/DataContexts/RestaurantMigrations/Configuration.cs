using System.Collections.Generic;
using System.Collections.ObjectModel;
using RestManager.Models;

namespace RestManager.DataContexts.RestaurantMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestManager.DataContexts.RestaurantDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\RestaurantMigrations";
        }

        protected override void Seed(RestManager.DataContexts.RestaurantDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //var address = new Address
            //{
            //    AddressLine1 = "add1",
            //    AddressLine2 = "add2",
            //    AddressLine3 = "add3",
            //    City = "London",
            //    PostCode = "Nw6 2dx"
            //};

            //context.Addresses.AddOrUpdate(address);
            //context.SaveChanges();

            //var products = new List<Product>
            //{
            //    new Product
            //    {
            //        Name = "Pizza",
            //        Price = 12.2M
            //    },
            //    new Product
            //    {
            //        Name = "Kebab",
            //        Price = 12
            //    },
            //    new Product
            //    {
            //        Name = "Rice",
            //        Price = 1
            //    }
            //};

            ////var orderItems = new List<OrderItem>();

            //foreach (var product in products)
            //{
            //    context.Products.Add(product);
            //    context.SaveChanges();

            //    //orderItems.Add(new OrderItem
            //    //{
            //    //    Product = product,
            //    //    UnitPrice = product.Price,
            //    //    Quantity = 1
            //    //});
            //}

            //foreach (var orderItem in orderItems)
            //{
            //    context.OrderItems.AddOrUpdate(orderItem);
            //    context.SaveChanges();
            //}

            //var customer = new Customer
            //{
            //    Address = new Address
            //    {
            //        AddressLine1 = "add3",
            //        AddressLine2 = "add2",
            //        AddressLine3 = "add3",
            //        City = "London",
            //        PostCode = "Nw6 3dx"
            //    }
            //};

            //context.Customers.AddOrUpdate(customer);
            //context.SaveChanges();

            //var order = new Order
            //{
            //    OrderDate = DateTime.Now,
            //    OrderItems = orderItems,
            //    Paid = true,
            //    Delivered = true,
            //    DeliveryTime = DateTime.Now.AddHours(1),
            //    DeliveredTime = DateTime.Now.AddHours(1).AddMinutes(45),
            //    Customer = customer
            //};

            //context.Orders.AddOrUpdate(order);
            //context.SaveChanges();

            var app = new IdentityContext();

            var rest = new Restaurant
            {
                Name = "My Restaurant",
                Address = new Address
                {
                    AddressLine1 = "add3",
                    AddressLine2 = "add2",
                    AddressLine3 = "add3",
                    City = "London",
                    PostCode = "Nw6 3dx"
                },
                RestaurantKey = Guid.NewGuid(),
                Orders = new Collection<Order>
                {
                    new Order
                    {
                        OrderDate = DateTime.Now,
                        OrderItems = new Collection<OrderItem>
                        {
                            new OrderItem
                            {
                                Product = new Product
                                {
                                    Name = "Kebab",
                                    Price = 5
                                },
                                Quantity = 1
                            },
                            new OrderItem
                            {
                                Product = new Product
                                {
                                    Name = "Pizza",
                                    Price = 10
                                },
                                Quantity = 4
                            },
                            new OrderItem
                            {
                                Product = new Product
                                {
                                    Name = "Nugget",
                                    Price = 3
                                },
                                Quantity = 11
                            }
                        },
                        Paid = true,
                        Delivered = true,
                        DeliveryTime = DateTime.Now.AddHours(1),
                        DeliveredTime = DateTime.Now.AddHours(1).AddMinutes(45),
                        Customer = new Customer
                        {
                            Address = new Address
                            {
                                AddressLine1 = "add3",
                                AddressLine2 = "add2",
                                AddressLine3 = "add3",
                                City = "London",
                                PostCode = "Nw6 3dx"
                            }
                        }
                    }
                },
                UserId = Guid.Parse(app.Users.FirstOrDefault().Id)
            };

            context.Restaurants.AddOrUpdate(p => p.Name, rest);
            context.SaveChanges();
        }
    }
}
