using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZoneMarker.Models
{
    public class TZone
    {
        public int TimeZoneID { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public string TimeZoneCode { get; set; }
        public TimeSpan UtcOffset { get; set; }
    }
}
