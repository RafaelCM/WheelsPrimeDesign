using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class AppointmentRequest
    {
        public int ID { get; set; }

        [DisplayName("Tipo de Serviço")]
        public virtual ServiceType ServiceType { set; get; }

        [DisplayName("Descrição")]
        public string Description { set; get; }

        [DisplayName("Veículo")]
        public virtual VehicleUser VehicleUser { set; get; }

        public virtual ICollection<DateInterval> AvailableDateInterval { get; set; }
    }
}