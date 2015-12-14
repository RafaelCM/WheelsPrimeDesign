using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Component
    {
        public int ID { set; get; }

        [DisplayName("Referência")]
        public string Ref { set; get; }
        
        [DisplayName("Descrição")]
        public string Description { set; get; }
        
        [DisplayName("Preço")]
        public double Price { set; get; }
        
        [DisplayName("Referência de concorrência")]
        public string RefCompetition { set; get; }

        public virtual ICollection<AppliedComponent> AppliedComponents { set; get; }
    }
}