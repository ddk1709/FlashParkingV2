using FlashParking.FlashParking.Data;
using System;
using System.Linq;

namespace FlashParking.Data.Repositories
{
    public class LocationDetailsRepository : ILocationDetailsRepository
    {
        public LocationDetailsRepository()
        {
        }

        /// <summary>
        /// Gets List of Carriers
        /// </summary>
        /// <param name="result"></param>
        public LocationDetail GetLocationDetails(int locationId)
        {
            LocationDetail result = new LocationDetail();
            try
            {
                using (FlashParkEntities dbContext = new FlashParkEntities())
                {
                    var data = dbContext.LocationDetails.Where(o => o.LocationId == locationId).FirstOrDefault();

                    result = new LocationDetail
                    {
                        Id = data.Id,
                        LocationId = data.LocationId,
                        AvailableSpots = data.AvailableSpots,
                        TotalSpots = data.TotalSpots,
                        Location = data.Location
                    };

                    return result;
                }
            }
            catch (Exception ex)
            {
                //Good to add logger here
                //Logger.Instance.Error("GetLocationDetails", ex, this);
                return result = new LocationDetail();
            }
        }

        /// <summary>
        /// Updating available spots on location when user enters or exits parking location
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="availableCount"></param>
        public void UpdateLocationDetails(int locationId, int availableCount)
        {
            try
            {
                using (FlashParkEntities dbContext = new FlashParkEntities())
                {
                    var data = dbContext.LocationDetails.Where(o => o.LocationId == locationId).FirstOrDefault();
                    data.AvailableSpots = availableCount;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Good to add logger here
                //Logger.Instance.Error("GetLocationDetails", ex, this);
            }
        }
    }
}
