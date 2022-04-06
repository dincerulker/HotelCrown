namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        IdentityNumber = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CheckedInTime = c.DateTime(nullable: false),
                        CheckedOutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReservationService_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ReservationServices", t => t.ReservationService_Id)
                .Index(t => t.ReservationService_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationCustomers",
                c => new
                    {
                        Reservation_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_Id, t.Customer_Id })
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Reservation_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.ReservationServiceReservations",
                c => new
                    {
                        ReservationService_Id = c.Int(nullable: false),
                        Reservation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReservationService_Id, t.Reservation_Id })
                .ForeignKey("dbo.ReservationServices", t => t.ReservationService_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .Index(t => t.ReservationService_Id)
                .Index(t => t.Reservation_Id);
            
            CreateTable(
                "dbo.FeatureRooms",
                c => new
                    {
                        Feature_Id = c.Int(nullable: false),
                        Room_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Feature_Id, t.Room_Id })
                .ForeignKey("dbo.Features", t => t.Feature_Id, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .Index(t => t.Feature_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.RoomReservations",
                c => new
                    {
                        Room_Id = c.Int(nullable: false),
                        Reservation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Room_Id, t.Reservation_Id })
                .ForeignKey("dbo.Rooms", t => t.Room_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .Index(t => t.Room_Id)
                .Index(t => t.Reservation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomReservations", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.RoomReservations", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "Feature_Id", "dbo.Features");
            DropForeignKey("dbo.Services", "ReservationService_Id", "dbo.ReservationServices");
            DropForeignKey("dbo.ReservationServiceReservations", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.ReservationServiceReservations", "ReservationService_Id", "dbo.ReservationServices");
            DropForeignKey("dbo.ReservationCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.ReservationCustomers", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.RoomReservations", new[] { "Reservation_Id" });
            DropIndex("dbo.RoomReservations", new[] { "Room_Id" });
            DropIndex("dbo.FeatureRooms", new[] { "Room_Id" });
            DropIndex("dbo.FeatureRooms", new[] { "Feature_Id" });
            DropIndex("dbo.ReservationServiceReservations", new[] { "Reservation_Id" });
            DropIndex("dbo.ReservationServiceReservations", new[] { "ReservationService_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.ReservationCustomers", new[] { "Reservation_Id" });
            DropIndex("dbo.Services", new[] { "ReservationService_Id" });
            DropTable("dbo.RoomReservations");
            DropTable("dbo.FeatureRooms");
            DropTable("dbo.ReservationServiceReservations");
            DropTable("dbo.ReservationCustomers");
            DropTable("dbo.Features");
            DropTable("dbo.Rooms");
            DropTable("dbo.Services");
            DropTable("dbo.ReservationServices");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
        }
    }
}
