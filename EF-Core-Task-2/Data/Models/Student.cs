using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_2.Data.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }

        [ForeignKey(nameof(department))]
        public int Dep_id { get; set; }

        public Department? department { get; set; }



    }
}
