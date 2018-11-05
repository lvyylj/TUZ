using System;

namespace TUZ.Entities
{
    internal class Train
    {
        
        public int Id { get; set; }

        public DateTime Departure { get; set; }
        
        public DateTime Arrive { get; set; }
        
        public int Duration { get; set; }
       
    }
}