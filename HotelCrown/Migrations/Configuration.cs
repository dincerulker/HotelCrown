namespace HotelCrown.Migrations
{
    using HotelCrown.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HotelCrown.Data.HotelCrownContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HotelCrown.Data.HotelCrownContext context)
        {
            if (!context.Services.Any())
            {
                List<Service> services = new List<Service>()
                {
                   new Service()
                   {
                       ServiceName = "Room Service",
                       UnitPrice = 50
                   },
                   new Service()
                   {
                       ServiceName = "Food Service",
                       UnitPrice = 100
                   },
                   new Service()
                   {
                       ServiceName = "Spa & Massage Service",
                       UnitPrice = 400
                   },
                   new Service()
                   {
                       ServiceName = "Alcohol Service",
                       UnitPrice = 500
                   },
                   new Service()
                   {
                       ServiceName = "Newspaper Service",
                       UnitPrice = 10
                   },
                   new Service()
                   {
                       ServiceName = "Additional Bad",
                       UnitPrice = 0
                   },
                   new Service()
                   {
                       ServiceName = "Loundry",
                       UnitPrice = 50
                   },
                   new Service()
                   {
                       ServiceName = "Ironing",
                       UnitPrice = 20
                   }
                };

                foreach (Service item in services)
                    context.Services.Add(item);
            }
            List<Feature> features;

            if (!context.Rooms.Any())
            {
                features = new List<Feature>()
                {
                   new Feature() { FeatureName = "TV", Id = 1 },
                   new Feature() { FeatureName = "Wi-Fi (Standart)", Id = 2 },
                   new Feature() { FeatureName = "Bathroom", Id = 3 },
                   new Feature() { FeatureName = "Mini Bar", Id = 4 },
                   new Feature() { FeatureName = "Towel", Id = 5 },
                   new Feature() { FeatureName = "Shampoo", Id = 6 },
                   new Feature() { FeatureName = "Shower Gel", Id = 7 },
                   new Feature() { FeatureName = "Slippers", Id = 8 },
                   new Feature() { FeatureName = "Bed", Id = 9 },
                   new Feature() { FeatureName = "Desk",Id = 10 },
                   new Feature() { FeatureName = "Wi-Fi", Id = 11 },
                   new Feature() { FeatureName = "Safe", Id = 12 },
                   new Feature() { FeatureName = "Balcony", Id = 13 },
                   new Feature() { FeatureName = "Jakuzi", Id = 14 },
                   new Feature() { FeatureName = "Hammock", Id = 15 },
                   new Feature() { FeatureName = "Smart Gadgets", Id = 16 }
                };

                foreach (Feature item in features)
                    context.Features.Add(item);

                List<Room> rooms = new List<Room>()
                {
                   new Room()
                   {
                       RoomName = "Standart",
                       Capacity = 2,
                       Features = features.Where(x=>x.Id < 11).ToList(),

                   },
                   new Room()
                   {
                       RoomName = "Queen",
                       Capacity = 4,
                       Features = features.Where(x=>x.Id < 14).ToList()
                   },
                   new Room()
                   {
                       RoomName = "King",
                       Capacity = 4,
                       Features = features.Where(x=>x.Id < 14).ToList()
                   },
                   new Room()
                   {
                       RoomName = "Suit",
                       Capacity = 6,
                       Features = features.ToList()
                   }
                };

                foreach (Room item in rooms)
                    context.Rooms.Add(item);
            }

            if (!context.Customers.Any())
            {
                Customer customer = new Customer()
                {
                    FullName = "Ali Veli",
                    IdentityNumber = "1234567890",
                    Gender = Gender.Erkek,
                    PhoneNumber = "+05439765432",
                    BirthDate = new DateTime(1999, 01, 01),
                };


                context.Customers.Add(customer);
            }
        }
    }
}
