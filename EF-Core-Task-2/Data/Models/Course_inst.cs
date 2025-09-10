using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_2.Data.Models
{
    internal class Course_inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public int? evaluate { get; set; }

        public Instructor? instructor { get; set; }

        public Course? course { get; set; }
    }
}
