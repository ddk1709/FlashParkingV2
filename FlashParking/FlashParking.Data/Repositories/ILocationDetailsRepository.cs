using FlashParking.FlashParking.Data;

namespace FlashParking.Data.Repositories
{
    public interface ILocationDetailsRepository
    {
        /// <summary>
        /// Get Location Details
        /// </summary>
        /// <param name="locationId"></param>
        /// <returns>LocationDetail</returns>
        LocationDetail GetLocationDetails(int locationId);

        /// <summary>
        /// Update Location Details
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="availableSpots"></param>
        /// <returns>LocationDetail</returns>
        void UpdateLocationDetails(int locationId, int availableSpots);
    }
}
