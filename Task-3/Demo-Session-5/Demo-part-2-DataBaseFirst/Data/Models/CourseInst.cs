using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class CourseInst
{
    public int InstId { get; set; }

    public int CourseId { get; set; }

    public int? Evaluate { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Instructor Inst { get; set; } = null!;
}
