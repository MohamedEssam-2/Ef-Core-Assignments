using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_ef_core.Data.Models
{
    //1)By Convention
    internal class Student
    {
        
        public int Id { get; set; }
        public string  FName { get; set; }
        public string LName { get; set; }
        public string ?Address { get; set; }
        public int? Age { get; set; }
        public int Dep_id { get; set; }

       
    }
}
