using System;
using System.Collections.Generic;

namespace pract_2;

public partial class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
