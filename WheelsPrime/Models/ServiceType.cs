using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class ServiceType
    {
        public int ID { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }
    }
}