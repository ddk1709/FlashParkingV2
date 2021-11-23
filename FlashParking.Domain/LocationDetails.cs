using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashParking.Domain
{
    public class LocationDetails
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int TotalSpots { get; set; }
        public int AvailableSpots { get; set; }
    }
}
