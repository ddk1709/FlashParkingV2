//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlashParking.FlashParking.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocationDetail
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int TotalSpots { get; set; }
        public int AvailableSpots { get; set; }
    
        public virtual Location Location { get; set; }
    }
}
