using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class Topic
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
