using FlashParking.Business;
using FlashParking.Domain;
using System;
using System.Web.Http;

namespace FlashParking.Controllers
{
    [RoutePrefix("api/ParkingApi")]
    public class ParkingApiController : ApiController
    {
        private readonly ILocationService locationService;
        public ParkingApiController()
        {
            var locationSrv = new LocationService();
            this.locationService = locationSrv ?? throw new ArgumentException(nameof(locationService));
        }

        [HttpGet]
        [Route("{locationId:int}")]
        public LocationDetails Get([FromUri]int locationId)
        {
            return locationService.GetLocationDetails(locationId);
        }

        [HttpPost]
        [Route("{actionType}/{locationId:int}")]
        public LocationDetails UpdateParkingSpots(int locationId, string actionType)
        {
            return locationService.UpdateLocationDetails(locationId, actionType);
        }
    }
}