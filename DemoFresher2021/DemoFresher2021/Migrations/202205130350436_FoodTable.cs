namespace DemoFresher2021.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FoodTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                {
                    FoodID = c.Int(nullable: false, identity: true),
                    FoodName = c.String(),
                    CateId = c.Int(nullable: false),
                    Description = c.String(),
                    Price = c.Double(nullable: false),
                    Image = c.String(nullable: false)
                })
                .PrimaryKey(t => t.FoodID);
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Image");
        }
    }
}

