namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "RoomName", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "RoomNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "RoomNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "RoomName");
        }
    }
}
