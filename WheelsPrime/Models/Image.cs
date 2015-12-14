using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Image
    {
        public int ID { get; set; }

        public string URL { get; set; }

        public virtual VehicleUser VehicleUser { get; set; }
        public virtual VehicleStand VehicleStand { get; set; }
        public virtual VehicleSold VehicleSold { get; set; }
    }
}