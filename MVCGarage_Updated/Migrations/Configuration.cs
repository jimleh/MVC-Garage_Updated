namespace MVCGarage_Updated.Migrations
{
    using MVCGarage_Updated.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCGarage_Updated.DataAccess.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCGarage_Updated.DataAccess.GarageContext context)
        {
            context.Vehicles.AddOrUpdate(
                v => v.VehicleID,
                    new Bus { VehicleID = 1, VehicleRegNum = "ABC-123", VehicleOwner = "BusMan", VehicleParkingSpot = 1 },
                    new Truck { VehicleID = 2, VehicleRegNum = "DEF-456", VehicleOwner = "TruckMan", VehicleParkingSpot = 4 },
                    new Car { VehicleID = 3, VehicleRegNum = "GHI-789", VehicleOwner = "CarMan", VehicleParkingSpot = 6 },
                    new MC { VehicleID = 4, VehicleRegNum = "CBA-321", VehicleOwner = "McMan", VehicleParkingSpot = 7 }
                );
        }
    }
}
