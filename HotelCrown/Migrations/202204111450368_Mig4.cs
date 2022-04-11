namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReservationServiceReservations", "ReservationService_Id", "dbo.ReservationServices");
            DropForeignKey("dbo.ReservationServiceReservations", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.ReservationServiceReservations", new[] { "ReservationService_Id" });
            DropIndex("dbo.ReservationServiceReservations", new[] { "Reservation_Id" });
            AddColumn("dbo.Reservations", "ReservationService_Id", c => c.Int());
            AddColumn("dbo.Services", "Reservation_Id", c => c.Int());
            CreateIndex("dbo.Reservations", "ReservationService_Id");
            CreateIndex("dbo.Services", "Reservation_Id");
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
            DropIndex("dbo.Services", new[] { "Reservation_Id" });
            DropIndex("dbo.Reservations", new[] { "ReservationService_Id" });
            DropColumn("dbo.Services", "Reservation_Id");
            DropColumn("dbo.Reservations", "ReservationService_Id");
            CreateIndex("dbo.ReservationServiceReservations", "Reservation_Id");
            CreateIndex("dbo.ReservationServiceReservations", "ReservationService_Id");
            AddForeignKey("dbo.ReservationServiceReservations", "Reservation_Id", "dbo.Reservations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReservationServiceReservations", "ReservationService_Id", "dbo.ReservationServices", "Id", cascadeDelete: true);
        }
    }
}
