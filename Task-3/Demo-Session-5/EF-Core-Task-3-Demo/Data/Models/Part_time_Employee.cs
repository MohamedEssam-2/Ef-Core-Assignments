using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_3_Demo.Data.Models
{
    internal class Part_time_Employee:Employee
    {
        public int Countofhours { get; set; }
        public int Hourly_Rate { get; set; }
    }
}
