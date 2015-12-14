using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class VehicleExtra
    {
        public int ID { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        public virtual VehicleUser VehicleUser { get; set; }
        public virtual VehicleStand VehicleStand { get; set; }
        public virtual VehicleSold VehicleSold { get; set; }
    }
}