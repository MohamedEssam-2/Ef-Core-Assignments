using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_ef_core.Data.Models
{ //3)By data Annotations
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName ="varchar(50)")]
        [MinLength(10)]
        [MaxLength(50)]
        public string ?Name { get; set; }
        public int Ins_id { get; set; }
        public DateTime? HiringDate { get; set; }
    }
}
