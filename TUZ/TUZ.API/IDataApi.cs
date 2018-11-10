using TUZ.Entities;

namespace TUZ.API
{
    public interface IDataApi
    {
        Train GetData(TripInfo tripInfo);
    }
}