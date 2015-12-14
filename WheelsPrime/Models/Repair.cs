using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Repair
    {
        public int ID { set; get; }

        [DisplayName("Custo da Mão de Obra")]
        public double LaborCost { set; get; }

        [DisplayName("Tempo de Mão de Obra")]
        public double LaborHours { get; set; }

        [DisplayName("Pronto a Levar")]
        public bool ReadyToTake { get; set; }
        public virtual ICollection<AppliedComponent> AppliedComponents { set; get; }
        public virtual VehicleCheckIn VehicleCheckIn { get; set; }
    }
}