using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class VehicleCheckOut
    {
        public int ID { get; set; }

        [DisplayName("Data de Saída")]
        public DateTime DateOfExit { get; set; }
        public virtual Repair Repair { get; set; }
    }
}