using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoFresher2021.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext() : base("DefaultConnection")
        {
        }
        public DbSet<Food> Foods { get; set; }
    }
}