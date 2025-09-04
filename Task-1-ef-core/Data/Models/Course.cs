using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_ef_core.Data.Models
{
    //By Convention
    internal class Course
    {
        public int Id { get; set; }
        public int ?Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_id { get; set; }
    }
}
