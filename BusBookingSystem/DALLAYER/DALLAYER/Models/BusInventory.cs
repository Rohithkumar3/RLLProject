using System;
using System.Collections.Generic;

namespace DALLAYER.Models
{
    public partial class BusInventory
    {
        public string BusId { get; set; } = null!;
        public string BusName { get; set; } = null!;
        public string? BusCategory { get; set; }
        public int AvailabilitySeats { get; set; }
        public string? Boarding { get; set; }
        public string? Departure { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public int? Price { get; set; }
    }
}
