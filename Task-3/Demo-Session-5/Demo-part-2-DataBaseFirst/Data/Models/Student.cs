using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Address { get; set; }

    public int? Age { get; set; }

    public int DepId { get; set; }

    public virtual Department Dep { get; set; } = null!;

    public virtual ICollection<StudCourse> StudCourses { get; set; } = new List<StudCourse>();
}
