using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_3_Demo.Data.Models
{
    internal class Stu_Dep_View
    {
        public string Dep_Name { get; set; }
        public int Dep_id { get; set; }
        public string ?Student_Name { get; set; }
    }
}
