using Microsoft.EntityFrameworkCore;
 
public class ApplicationContext_2 : DbContext
{
    
    public /*virtual*/ DbSet<Department> Departments { get; set; }

    public /*virtual*/ DbSet<Employee> Employees { get; set; }

    public /*virtual*/ DbSet<Position> Positions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Compan.db");
    }

  
}

 

