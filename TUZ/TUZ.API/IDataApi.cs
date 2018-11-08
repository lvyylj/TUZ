using TUZ.Entities;

namespace TUZ.API
{
    public interface IDataApi
    {
        Truck GetData(TripInfo tripInfo);
    }
}