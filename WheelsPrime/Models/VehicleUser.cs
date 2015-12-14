using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace WheelsPrime.Models
{
    public class VehicleUser : Vehicle
    {

        [DisplayName("Utilziador")]
        public virtual ApplicationUser User { get; set; }

        [DisplayName("Consumos")]
        public virtual ICollection<Consumption> Consumption { get; set; }

        [DisplayName("Despesa Adicional")]
        public virtual ICollection<Expense> Expense { get; set; }

        [DisplayName("Marcação")]
        public virtual ICollection<AppointmentRequest> AppointmentRequest { get; set; }
        [DisplayName("Modelo")]
        public virtual Model Model { get; set; }

        [DisplayName("Tipo de Combustível")]
        public virtual FuelType FuelType { set; get; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<VehicleExtra> Extras { get; set; }
    }
}