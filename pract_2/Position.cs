using System;
using System.Collections.Generic;

namespace pract_2;

public partial class Position
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string PositionsName { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
