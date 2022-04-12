namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "Reservation_Id", "dbo.Reservations");
            DropIndex("dbo.Services", new[] { "Reservation_Id" });
            CreateTable(
                "dbo.ServiceReservations",
                c => new
                    {
                        Service_Id = c.Int(nullable: false),
                        Reservation_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_Id, t.Reservation_Id })
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id, cascadeDelete: true)
                .Index(t => t.Service_Id)
                .Index(t => t.Reservation_Id);
            
            DropColumn("dbo.Services", "Reservation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Reservation_Id", c => c.Int());
            DropForeignKey("dbo.ServiceReservations", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.ServiceReservations", "Service_Id", "dbo.Services");
            DropIndex("dbo.ServiceReservations", new[] { "Reservation_Id" });
            DropIndex("dbo.ServiceReservations", new[] { "Service_Id" });
            DropTable("dbo.ServiceReservations");
            CreateIndex("dbo.Services", "Reservation_Id");
            AddForeignKey("dbo.Services", "Reservation_Id", "dbo.Reservations", "Id");
        }
    }
}
