using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class AppliedComponent
    {
        public int ID { set; get; }

        [DisplayName("Quantidade")]
        public int Amounts { set; get; }

        [DisplayName("Aceite")]
        public bool Accepted { set; get; }

        [DisplayName("Componente")]
        public Component Component { set; get; }

        [DisplayName("Reparação")]
        public Repair Repair { set; get; }
    }
}