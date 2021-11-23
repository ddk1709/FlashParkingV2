using FlashParking.Domain;

namespace FlashParking.Business
{
    public interface ILocationService
    {
        LocationDetails GetLocationDetails(int locationId);

        LocationDetails UpdateLocationDetails(int locationId, string actionType);
    }
}
