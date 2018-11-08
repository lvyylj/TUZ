

using System.Dynamic;
using TUZ.Entities;

namespace TUZ.API
{
    public interface IDataApi
    {
        Truck GetData(TripInfo a);
    }
}