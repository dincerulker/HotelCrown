using HotelCrown.Strategies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data
{
    public class HotelCrownContext : DbContext
    {
        public HotelCrownContext() : base("name=HotelCrownContext")
        {
            Database.SetInitializer(new DbStrategie());
        }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Reservation> Reservations { get; set; }       
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ReservationService> reservationServices { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
