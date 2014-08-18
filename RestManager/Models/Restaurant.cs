using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestManager.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid RestaurantKey { get; set; }

        public virtual Address Address { get; set; }

        public Guid UserId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}