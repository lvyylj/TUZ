using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using TUZ.Entities;
using Xunit;

namespace TUZ.API.Tests
{
    public class DataApiMock : IDataApi
    {
        
        
        
        
        
        public bool IsHolded { get; set; }

        public Truck GetData(TripInfo tripinfo)
        {
            // Some work
            int Id = new int();
            DateTime Departure = new DateTime(2018,11,22,15,0,0);
            DateTime Arrive = new DateTime(2018,11,23,15,0,0);
            TimeSpan Duration = new TimeSpan(1,0,0,0);
            Truck Truck  = new Truck();
            Truck.Type = TruckType.K;
            Truck.Place.Number = 12;
            Truck.IsHolded = false;
            return Truck;

        }
        
        
        
    }
}