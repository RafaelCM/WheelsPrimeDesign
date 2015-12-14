using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Expense
    {
        public int ID { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Preço")]
        public int Price { get; set; }
        // public int VehicleWorkshopID { set; get; }

        public virtual VehicleUser VehicleUser { set; get; }
    }
}