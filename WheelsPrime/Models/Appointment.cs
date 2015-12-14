using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Appointment
    {
        public int ID { get; set; }

        [DisplayName("Data")]
        public DateTime DateTime { set; get; }

        public virtual ICollection<Notification> Notifications { get; set; }

        public virtual AppointmentRequest AppointmentRequest { get; set; }

    }
}