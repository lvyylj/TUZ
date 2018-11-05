using System;

namespace TUZ.Entities
{
    internal class Get
    {
        private string _from;
        public string From
        {
            get => _from;
            set => _from = value;
        }

        private string _to;
        public string To
        {
            get => _to;
            set => _to = value;

        }

        private DateTime _schedule;
        public DateTime Schedule
        {
            get => _schedule;
            set => _schedule = value;
        }
    }
}