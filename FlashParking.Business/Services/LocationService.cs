using FlashParking.Data.Repositories;
using FlashParking.Domain;
using System;

namespace FlashParking.Business
{
    public class LocationService : ILocationService
    {
        private readonly ILocationDetailsRepository locationDetailsRepository;

        // Good way to implement DI. 
        //public LocationService(ILocationDetailsRepository locationDetailsRepository)
        //{
        //    this.locationDetailsRepository = locationDetailsRepository ?? throw new ArgumentNullException(nameof(locationDetailsRepository));
        //}

        public LocationService()
        {
            var locationDetailsRepo = new LocationDetailsRepository();
            this.locationDetailsRepository = locationDetailsRepo ?? throw new ArgumentNullException(nameof(locationDetailsRepository));            
        }

        public LocationDetails GetLocationDetails(int locationId)
        {
            LocationDetails details = new LocationDetails();
            var locationDetails = locationDetailsRepository.GetLocationDetails(locationId);
            details.Id = locationDetails.Id;
            details.AvailableSpots = locationDetails.AvailableSpots;
            details.TotalSpots = locationDetails.TotalSpots;
            details.LocationId = locationDetails.LocationId;
            return details;
        }

        /// <summary>
        /// Update LocationDetails Count
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="actionType"></param>
        /// <returns>LocationDetails</returns>
        public LocationDetails UpdateLocationDetails(int locationId, string actionType)
        {
            var locationDetails = GetLocationDetails(locationId);
            int availableSpots = locationDetails.AvailableSpots; 
            if (actionType.ToLower() == "add")
            {
                availableSpots++; 
                if (availableSpots > locationDetails.TotalSpots)
                {
                    //Good to add user readable exception
                    throw new Exception("Parking lot is full");
                }
            }
            else if (actionType.ToLower() == "delete")
            {
                availableSpots--;
            }

            locationDetailsRepository.UpdateLocationDetails(locationId, availableSpots);
            locationDetails.AvailableSpots = availableSpots;
            return locationDetails;
        }

    }
}
