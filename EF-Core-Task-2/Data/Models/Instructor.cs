using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_2.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Bouns { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public int? HourRate { get; set; }

        [ForeignKey(nameof(Work_in_Dep))]
        public int Dep_id { get; set; }

        public Department? Work_in_Dep { get; set; }

        public Department? Manage_Department { get; set; }



    }
}
