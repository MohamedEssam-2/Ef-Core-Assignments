using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_2.Data.Models
{
    internal class Department
    {
      
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [MinLength(10)]
        [MaxLength(50)]
        public string? Name { get; set; }
       
        public DateTime? HiringDate { get; set; }

        public List<Student>? Students { get; set; }
        public  List<Instructor>? Instructors { get; set; }

        [ForeignKey(nameof(Manager))]
        public int? Ins_Id { get; set; }
        public Instructor? Manager { get; set; }
    }
}
