using System;

namespace TUZ.Entities
{
    internal class WeTake
    {
        private DateTime _departure;
        private int  _id;

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
    }
}