using System;
using System.Collections.Generic;

namespace TUZ.Entities
{
    public class Train
    {
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrive { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}    