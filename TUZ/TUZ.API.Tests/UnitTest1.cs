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
        
        
        
        
        
        

        public Truck GetData(TripInfo tripinfo)
        {
            // Some work
            int Id = new int();
            DateTime departure = new DateTime(2018,11,22,15,0,0);
            DateTime arrive = new DateTime(2018,11,23,15,0,0);
            TimeSpan duration = new TimeSpan(1,0,0,0);
            Truck truck  = new Truck();
            truck.Type = TruckType.K;
            truck.Place.Number = 12;
            truck.Place.IsHolded = true;
            return truck;

        }
        
        
        
    }
}