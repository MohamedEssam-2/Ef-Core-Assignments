using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task_2.Data.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public int? Duration { get; set; }
        public string ?Name { get; set; }
        public string ?Description { get; set; }
        [ForeignKey(nameof(Top))]
        public int Top_id { get; set; }
        public Topic? Top { get; set; }
    }
}
