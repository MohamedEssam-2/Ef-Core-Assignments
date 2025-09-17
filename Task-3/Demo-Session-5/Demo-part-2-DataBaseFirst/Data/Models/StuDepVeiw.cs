using System;
using System.Collections.Generic;

namespace Demo_part_2_DataBaseFirst.Data.Models;

public partial class StuDepVeiw
{
    public string StudentName { get; set; } = null!;

    public string? DepName { get; set; }

    public int DepId { get; set; }
}
