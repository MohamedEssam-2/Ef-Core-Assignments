using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_ef_core.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int Bouns { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public int? HourRate { get; set; }
        public int Dep_id { get; set; }
    }
}
