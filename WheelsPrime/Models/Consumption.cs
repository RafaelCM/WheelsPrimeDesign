using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WheelsPrime.Models
{
    public class Consumption
    {
        public int ID { set; get; }

        [DisplayName("Odômetro")]
        public int Odometer { set; get; }

        [DisplayName("Litros")]
        public double Liters { set; get; }

        [DisplayName("Preço p/ Litro")]
        public double PriceLiter { set; get; }

        [DisplayName("Data")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public virtual VehicleUser VehicleUser { set; get; }

        [DisplayName("Deposito Cheio?")]
        public bool Full { set; get; }
    }
}