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
        
        
        
        
        
        

        public Train GetData(TripInfo tripinfo)
        {
            // Some work
            Train train = new Train();
            train.Arrive = new DateTime(2018,12,10,15,0,0);
            train.Departure = new DateTime(2018,12,10,16,0,0);
            train.Id = 12;
            train.Duration = train.Arrive - train.Departure;
            train.Trucks = new List<Truck>();
            
            return train;

        }
        
        
        
    }
}