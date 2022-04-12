namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReservationServiceReservations", "ReservationService_Id", "dbo.ReservationServices");
            DropForeignKey("dbo.ReservationServiceReservations", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.ReservationServiceReservations", new[] { "ReservationService_Id" });
            DropIndex("dbo.ReservationServiceReservations", new[] { "Reservation_Id" });
            AddColumn("dbo.Customers", "Room_Id", c => c.Int());
            AddColumn("dbo.Reservations", "RoomName", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "ReservationService_Id", c => c.Int());
            AddColumn("dbo.Services", "Reservation_Id", c => c.Int());
            AddColumn("dbo.Rooms", "RoomNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "CheckedInTime", c => c.DateTime());
            AlterColumn("dbo.Reservations", "CheckedOutTime", c => c.DateTime());
            CreateIndex("dbo.Customers", "Room_Id");
            CreateIndex("dbo.Reservations", "ReservationService_Id");
            CreateIndex("dbo.Services", "Reservation_Id");
            AddForeignKey("dbo.Customers", "Room_Id", "dbo.Rooms", "Id");
            AddForeignKey("dbo.Reservations", "ReservationService_Id", "dbo.ReservationServices", "Id");
            AddForeignKey("dbo.Services", "Reservation_Id", "dbo.Reservations", "Id");
            DropTable("dbo.ReservationServiceReservations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ReservationServiceReservations",
                c => new
                    {
                        ReservationService_Id = c.Int(nullable: false),
                        Reservation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReservationService_Id, t.Reservation_Id });
            
            DropForeignKey("dbo.Services", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "ReservationService_Id", "dbo.ReservationServices");
            DropForeignKey("dbo.Customers", "Room_Id", "dbo.Rooms");
            DropIndex("dbo.Services", new[] { "Reservation_Id" });
            DropIndex("dbo.Reservations", new[] { "ReservationService_Id" });
            DropIndex("dbo.Customers", new[] { "Room_Id" });
            AlterColumn("dbo.Reservations", "CheckedOutTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Reservations", "CheckedInTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String());
            DropColumn("dbo.Rooms", "RoomNumber");
            DropColumn("dbo.Services", "Reservation_Id");
            DropColumn("dbo.Reservations", "ReservationService_Id");
            DropColumn("dbo.Reservations", "RoomName");
            DropColumn("dbo.Customers", "Room_Id");
            CreateIndex("dbo.ReservationServiceReservations", "Reservation_Id");
            CreateIndex("dbo.ReservationServiceReservations", "ReservationService_Id");
            AddForeignKey("dbo.ReservationServiceReservations", "Reservation_Id", "dbo.Reservations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReservationServiceReservations", "ReservationService_Id", "dbo.ReservationServices", "Id", cascadeDelete: true);
        }
    }
}
