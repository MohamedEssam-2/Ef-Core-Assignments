using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_3_Demo.Data.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int age { get; set; }

        public string ?address { get; set; }


    }
}
