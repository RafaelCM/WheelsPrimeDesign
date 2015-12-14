using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace WheelsPrime.Models
{
    public class Notification
    {
        public int ID { set; get; }

        [DisplayName("Descrição")]
        public string Description { set; get; }

        [DisplayName("Verificado")]
        public bool Viewed { set; get; }

        [DisplayName("Utilizador")]
        public virtual ApplicationUser User { get; set; }

        [DisplayName("Stand")]
        public virtual VehicleStand VehicleStand { set; get; }

        [DisplayName("Marcação")]
        public virtual Appointment Appointment { set; get; }

    }
}