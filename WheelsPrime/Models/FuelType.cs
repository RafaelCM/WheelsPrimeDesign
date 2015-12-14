using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class FuelType
    {
        public int ID { get; set; }

        [DisplayName("Tipo de combustível")]
        public string Type { get; set; }

        public virtual ICollection<VehicleUser> VehicleUser { get; set; }
        public virtual ICollection<VehicleStand> VehicleStand { get; set; }
        public virtual ICollection<VehicleSold> VehicleSold { get; set; }
    }
}