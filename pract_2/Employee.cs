using System;
using System.Collections.Generic;

namespace pract_2;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PositionId { get; set; }

    public virtual Position Position { get; set; } = null!;
}
