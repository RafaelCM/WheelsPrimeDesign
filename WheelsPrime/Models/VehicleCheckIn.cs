using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class VehicleCheckIn
    {
        public int ID { get; set; }

        [DisplayName("Data de Entrada")]
        public DateTime DateOfEntrace { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}