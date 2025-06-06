﻿using Microsoft.EntityFrameworkCore;
 
public class ApplicationContext : DbContext
{
    
    public /*virtual*/ DbSet<Department> Departments { get; set; }

    public /*virtual*/ DbSet<Employee> Employees { get; set; }

    public /*virtual*/ DbSet<Position> Positions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Company.db");
    }

   
}

 

public partial class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual List<Position> Positions { get; set; } = new List<Position>();
}
public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int PositionId { get; set; }

    public virtual Position? Position { get; set; } = null!;
}
public partial class Position
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string PositionsName { get; set; } = null!;

    public virtual Department? Department { get; set; }

    public virtual List<Employee> Employees { get; set; } = new List<Employee>();
}