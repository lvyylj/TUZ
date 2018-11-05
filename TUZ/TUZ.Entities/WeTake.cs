using System;

namespace TUZ.Entities
{
    internal class WeTake
    {
        private DateTime _departure;
        private int  _id;
        private DateTime _arrive;
        private int _duration;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public DateTime Departure
        {
            get => _departure;
            set => _departure = value;
        }
        
        public DateTime Arrive
        {
            get => _arrive;
            set => _arrive = value;
        }
        
        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }
    }
}