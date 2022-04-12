namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "ReservationService_Id", "dbo.ReservationServices");
            DropForeignKey("dbo.Services", "ReservationService_Id", "dbo.ReservationServices");
            DropIndex("dbo.Reservations", new[] { "ReservationService_Id" });
            DropIndex("dbo.Services", new[] { "ReservationService_Id" });
            DropColumn("dbo.Reservations", "ReservationService_Id");
            DropColumn("dbo.Services", "ReservationService_Id");
            DropTable("dbo.ReservationServices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReservationServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ServiceNumber = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Services", "ReservationService_Id", c => c.Int());
            AddColumn("dbo.Reservations", "ReservationService_Id", c => c.Int());
            CreateIndex("dbo.Services", "ReservationService_Id");
            CreateIndex("dbo.Reservations", "ReservationService_Id");
            AddForeignKey("dbo.Services", "ReservationService_Id", "dbo.ReservationServices", "Id");
            AddForeignKey("dbo.Reservations", "ReservationService_Id", "dbo.ReservationServices", "Id");
        }
    }
}
