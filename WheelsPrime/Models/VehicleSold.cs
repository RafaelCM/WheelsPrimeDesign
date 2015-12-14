using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class VehicleSold:Vehicle
    {

        [DisplayName("Data de Venda")]
        public DateTime DateOfSale { get; set; }
        
        public virtual ApplicationUser User { get; set; }
        
        [DisplayName("Preço")]
        public int Price { set; get; }
        
        [DisplayName("Modelo")]
        public virtual Model Model { get; set; }

        [DisplayName("Tipo de Combustível")]
        public virtual FuelType FuelType { set; get; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<VehicleExtra> Extras { get; set; }
    }
}