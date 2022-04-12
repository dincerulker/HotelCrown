namespace HotelCrown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "ReservationService_Id", "dbo.ReservationServices");
            AddColumn("dbo.Services", "ReservationService_Id1", c => c.Int());
            CreateIndex("dbo.Services", "ReservationService_Id1");
            AddForeignKey("dbo.Services", "ReservationService_Id1", "dbo.ReservationServices", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "ReservationService_Id1", "dbo.ReservationServices");
            DropIndex("dbo.Services", new[] { "ReservationService_Id1" });
            DropColumn("dbo.Services", "ReservationService_Id1");
            AddForeignKey("dbo.Services", "ReservationService_Id", "dbo.ReservationServices", "Id");
        }
    }
}
