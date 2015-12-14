using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class Brand
    {
        public int ID { set; get; }

        [DisplayName("Nome")]
        public string Name { set; get; }

        public virtual ICollection<Model> Model { set; get; }
    }
}