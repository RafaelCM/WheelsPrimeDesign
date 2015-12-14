using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Model
    {
        public int ID { set; get; }

        [DisplayName("Nome")] 
        public string Name { set; get; }
        //public int BrandID { set; get; }

        [DisplayName("Marca")]
        public virtual Brand Brand { set; get; }
        public virtual ICollection<VehicleUser> VehicleUser { get; set; }
        public virtual ICollection<VehicleStand> VehicleStand { get; set; }
        public virtual ICollection<VehicleSold> VehicleSold { get; set; }

    }
}