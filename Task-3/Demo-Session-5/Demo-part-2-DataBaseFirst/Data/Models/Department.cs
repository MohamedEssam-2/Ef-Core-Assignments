using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? InsId { get; set; }

    public DateTime? HiringDate { get; set; }

    public virtual Instructor? Ins { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
