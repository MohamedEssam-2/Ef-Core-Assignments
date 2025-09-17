using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class Course
{
    public int Id { get; set; }

    public int? Duration { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int TopId { get; set; }

    public virtual ICollection<CourseInst> CourseInsts { get; set; } = new List<CourseInst>();

    public virtual ICollection<StudCourse> StudCourses { get; set; } = new List<StudCourse>();

    public virtual Topic Top { get; set; } = null!;
}
