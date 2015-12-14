using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WheelsPrime.Models
{
    public class DateInterval
    {
        public int ID { get; set; }

        [DisplayName("Data Inicial")]
        public DateTime InitialDate { get; set; }
        
        [DisplayName("Data Final")]
        public DateTime EndDate { get; set; }
    }
}