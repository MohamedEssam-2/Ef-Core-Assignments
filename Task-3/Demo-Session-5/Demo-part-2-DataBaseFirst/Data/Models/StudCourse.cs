using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class StudCourse
{
    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public int? Grade { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
