namespace TUZ.Entities
{
    public class Truck
    {
        public TruckType Type { get; set; }
        public Place Place { get; set; }   
        public bool IsHolded { get; set; }
    }
}