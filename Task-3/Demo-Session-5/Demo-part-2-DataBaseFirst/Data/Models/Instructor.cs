using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Bouns { get; set; }

    public int Salary { get; set; }

    public string? Address { get; set; }

    public int? HourRate { get; set; }

    public int DepId { get; set; }

    public virtual ICollection<CourseInst> CourseInsts { get; set; } = new List<CourseInst>();

    public virtual Department Dep { get; set; } = null!;

    public virtual Department? Department { get; set; }
}
