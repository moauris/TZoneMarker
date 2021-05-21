using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZoneMarker.Models
{
    public interface IAppRepository
    {
        public IEnumerable<TZone> TimeZones { get; }
    }
}
