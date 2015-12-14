using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class VehicleStand:Vehicle
    {
        //public int ID { set; get; }

        [DisplayName("Preço")]
        public int Price { set; get; }

        public virtual ICollection<Notification> Notification { get; set; }

        [DisplayName("Utilizador Interessado")]
        public virtual ApplicationUser InterestedUser { get; set; }

        [DisplayName("Modelo")]
        public virtual Model Model { get; set; }

        [DisplayName("Tipo de Combustível")]
        public virtual FuelType FuelType { set; get; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<VehicleExtra> Extras { get; set; }

    }
}