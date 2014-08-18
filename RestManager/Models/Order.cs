using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestManager.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public Customer Customer { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime DeliveredTime { get; set; }
        public bool Delivered { get; set; }
        public bool Paid { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public Address Address { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public Decimal Discount { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}
