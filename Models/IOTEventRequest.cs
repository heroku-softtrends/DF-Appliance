using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFAppliance.Models
{
    public class IOTEventRequest
    {
        public string appID { get; set; }
        public int distance_to_beacon { get; set; }
        public string appStatus { get; set; }
    }
}
