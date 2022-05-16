namespace DemoFresher2021.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DemoFresher2021.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoFresher2021.Models.FoodContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoFresher2021.Models.FoodContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Foods.AddOrUpdate(x => x.FoodID,
                new Food() { FoodID = 1, FoodName = "Bread", CateId = 1, Description = "Updating...", Price = 3},
                new Food() { FoodID = 2, FoodName = "Fried Rice", CateId = 1, Description = "Updating...", Price = 3}
                );
        }
    }
}
