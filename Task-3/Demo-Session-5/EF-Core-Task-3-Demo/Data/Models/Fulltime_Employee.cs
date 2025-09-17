using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_3_Demo.Data.Models
{
    internal class Fulltime_Employee:Employee
    {
        public int Salary { get; set; }
        public int Bonus { get; set; }
    }
}
