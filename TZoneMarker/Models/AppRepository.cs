using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZoneMarker.Models
{
    public class AppRepository : IAppRepository
    {
        public IEnumerable<TZone> TimeZones
        {
            get
            {
                yield return new TZone
                {
                    TimeZoneID = 0,
                    TimeZoneCode = "CST",
                    CityName = "Beijing",
                    Country = "China",
                    UtcOffset = TimeSpan.FromHours(8)
                };
                yield return new TZone
                {
                    TimeZoneID = 1,
                    TimeZoneCode = "AEST",
                    CityName = "Canberra",
                    Country = "Australia",
                    UtcOffset = TimeSpan.FromHours(10)
                };
                yield return new TZone
                {
                    TimeZoneID = 2,
                    TimeZoneCode = "NZST",
                    CityName = "Wellington",
                    Country = "New Zealand",
                    UtcOffset = TimeSpan.FromHours(12)
                };
                yield return new TZone
                {
                    TimeZoneID = 3,
                    TimeZoneCode = "IST",
                    CityName = "New Delhi",
                    Country = "India",
                    UtcOffset = TimeSpan.FromHours(-2.5)
                };
            }

        }
    }
}
