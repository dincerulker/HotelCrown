namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Room_Id", "dbo.Rooms");
            DropIndex("dbo.Customers", new[] { "Room_Id" });
            DropColumn("dbo.Customers", "Room_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Room_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Room_Id");
            AddForeignKey("dbo.Customers", "Room_Id", "dbo.Rooms", "Id");
        }
    }
}
