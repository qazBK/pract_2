using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Department Development = new Department { DepartmentName = "Разработка" };
    Department Design = new Department { DepartmentName = "Дизайн" };
    Department Marketing = new Department { DepartmentName = "Маркетинг" };
    Department Sales = new Department { DepartmentName = "Продажи" };


    db.Departments.AddRange(Development, Design, Marketing, Sales);

    Position Development_Charc = new Position { Department = Development, PositionsName = "Разработчик C#" };
    Position Development_Java = new Position { Department = Development, PositionsName = "Разработчик Java" };
    Position Development_Frontend = new Position { Department = Development, PositionsName = "Frontend-разработчик" };
    Position Design_iтterface = new Position { Department = Design, PositionsName = "Дизайнер интерфейсов" };
    Position Graphic_designer = new Position { Department = Design, PositionsName = "Графический дизайнер" };
    Position Marketer = new Position { Department = Marketing, PositionsName = "Маркетолог" };
    Position Content_Specialist = new Position { Department = Marketing, PositionsName = "Специалист по контенту" };
    Position Sales_managerer = new Position { Department = Sales, PositionsName = "Менеджер по продажам" };



    db.Positions.AddRange(Development_Charc, Development_Java, Development_Frontend, Design_iтterface, Graphic_designer, Marketer, Content_Specialist, Sales_managerer);




    Employee Employee_1 = new Employee { FirstName = "Иван", LastName = "Иванов", Position = Development_Charc };
    Employee Employee_2 = new Employee { FirstName = "Пётр", LastName = "Петров", Position = Development_Charc };
    Employee Employee_3 = new Employee { FirstName = "Иван", LastName = "Иванов", Position = Development_Java };
    Employee Employee_4 = new Employee { FirstName = "Светлана", LastName = "Сидорова", Position = Graphic_designer };
    Employee Employee_5 = new Employee { FirstName = "Анна", LastName = "Кузницова", Position = Development_Frontend };
    Employee Employee_6 = new Employee { FirstName = "Ян", LastName = "Ивин", Position = Design_iтterface };
    Employee Employee_7 = new Employee { FirstName = "Игорь", LastName = "Шерстюк", Position = Development_Java };
    Employee Employee_8 = new Employee { FirstName = "Антон", LastName = "Татыржа", Position = Sales_managerer };
    Employee Employee_9 = new Employee { FirstName = "Кирил", LastName = "Барано", Position = Marketer };
    Employee Employee_10 = new Employee { FirstName = "Константин", LastName = "Смерч", Position = Content_Specialist };
    Employee Employee_11 = new Employee { FirstName = "Арту", LastName = "Пирпжков", Position = Development_Frontend };
    db.Employees.AddRange(Employee_1, Employee_2, Employee_3, Employee_4, Employee_5, Employee_6, Employee_7, Employee_8, Employee_9, Employee_10, Employee_11);


    db.SaveChanges();

}



using (ApplicationContext db = new ApplicationContext())
{    // Получаем всех сотрудников вместе с их позициями и отделами
    var users = db.Employees
        .Include(u => u.Position) // Загружаем позиции сотрудников
            .ThenInclude(pos => pos.Department); // Загружаем отделы для позиций
    Console.WriteLine("-----------Eager loading-----------");
    foreach (var user in users)
    {
        
        Console.WriteLine($"{user.FirstName} {user.LastName}\nДолжность:  {user.Position?.PositionsName}\nОтдел: {user.Position?.Department?.DepartmentName} ");
        Console.WriteLine("----------------------"); // Для красоты
    }
}//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using (ApplicationContext_2 db = new ApplicationContext_2())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Department Development = new Department { DepartmentName = "Разработка" };
    Department Design = new Department { DepartmentName = "Дизайн" };
    Department Marketing = new Department { DepartmentName = "Маркетинг" };
    Department Sales = new Department { DepartmentName = "Продажи" };


    db.Departments.AddRange(Development, Design, Marketing, Sales);

    Position Development_Charc = new Position { Department = Development, PositionsName = "Разработчик C#" };
    Position Development_Java = new Position { Department = Development, PositionsName = "Разработчик Java" };
    Position Development_Frontend = new Position { Department = Development, PositionsName = "Frontend-разработчик" };
    Position Design_iтterface = new Position { Department = Design, PositionsName = "Дизайнер интерфейсов" };
    Position Graphic_designer = new Position { Department = Design, PositionsName = "Графический дизайнер" };
    Position Marketer = new Position { Department = Marketing, PositionsName = "Маркетолог" };
    Position Content_Specialist = new Position { Department = Marketing, PositionsName = "Специалист по контенту" };
    Position Sales_managerer = new Position { Department = Sales, PositionsName = "Менеджер по продажам" };



    db.Positions.AddRange(Development_Charc, Development_Java, Development_Frontend, Design_iтterface, Graphic_designer, Marketer, Content_Specialist, Sales_managerer);




    Employee Employee_1 = new Employee { FirstName = "Иван", LastName = "Иванов", Position = Development_Charc };
    Employee Employee_2 = new Employee { FirstName = "Пётр", LastName = "Петров", Position = Development_Charc };
    Employee Employee_3 = new Employee { FirstName = "Иван", LastName = "Иванов", Position = Development_Java };
    Employee Employee_4 = new Employee { FirstName = "Светлана", LastName = "Сидорова", Position = Graphic_designer };
    Employee Employee_5 = new Employee { FirstName = "Анна", LastName = "Кузницова", Position = Development_Frontend };
    Employee Employee_6 = new Employee { FirstName = "Ян", LastName = "Ивин", Position = Design_iтterface };
    Employee Employee_7 = new Employee { FirstName = "Игорь", LastName = "Шерстюк", Position = Development_Java };
    Employee Employee_8 = new Employee { FirstName = "Антон", LastName = "Татыржа", Position = Sales_managerer };
    Employee Employee_9 = new Employee { FirstName = "Кирил", LastName = "Барано", Position = Marketer };
    Employee Employee_10 = new Employee { FirstName = "Константин", LastName = "Смерч", Position = Content_Specialist };
    Employee Employee_11 = new Employee { FirstName = "Арту", LastName = "Пирпжков", Position = Development_Frontend };
    db.Employees.AddRange(Employee_1, Employee_2, Employee_3, Employee_4, Employee_5, Employee_6, Employee_7, Employee_8, Employee_9, Employee_10, Employee_11);


    db.SaveChanges();

}



using (ApplicationContext_2 db = new ApplicationContext_2())
{
    // Получаем всех сотрудников
    var users = db.Employees.ToList(); // Загружаем сотрудников

    Console.WriteLine("-----------Explicit loading-----------");

    foreach (var user in users)
    {
        // Явно загружаем позицию сотрудника
        db.Entry(user).Reference(u => u.Position).Load();

        // Если позиция загружена, явно загружаем отдел
        if (user.Position != null)
        {
            db.Entry(user.Position).Reference(pos => pos.Department).Load();
        }

        Console.WriteLine($"{user.FirstName} {user.LastName}\nДолжность:  {user.Position?.PositionsName}\nОтдел: {user.Position?.Department?.DepartmentName} ");
        Console.WriteLine("----------------------"); // Для красоты
    }
}



//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

using (ApplicationContext_3 db = new ApplicationContext_3())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Department Development = new Department { DepartmentName = "Разработка" };
    Department Design = new Department { DepartmentName = "Дизайн" };
    Department Marketing = new Department { DepartmentName = "Маркетинг" };
    Department Sales = new Department { DepartmentName = "Продажи" };


    db.Departments.AddRange(Development, Design, Marketing, Sales);

    Position Development_Charc = new Position { Department = Development, PositionsName = "Разработчик C#" };
    Position Development_Java = new Position { Department = Development, PositionsName = "Разработчик Java" };
    Position Development_Frontend = new Position { Department = Development, PositionsName = "Frontend-разработчик" };
    Position Design_iтterface = new Position { Department = Design, PositionsName = "Дизайнер интерфейсов" };
    Position Graphic_designer = new Position { Department = Design, PositionsName = "Графический дизайнер" };
    Position Marketer = new Position { Department = Marketing, PositionsName = "Маркетолог" };
    Position Content_Specialist = new Position { Department = Marketing, PositionsName = "Специалист по контенту" };
    Position Sales_managerer = new Position { Department = Sales, PositionsName = "Менеджер по продажам" };



    db.Positions.AddRange(Development_Charc, Development_Java, Development_Frontend, Design_iтterface, Graphic_designer, Marketer, Content_Specialist, Sales_managerer);




    Employee Employee_1 = new Employee { FirstName = "Иван", LastName = "Иванов", Position = Development_Charc };
    Employee Employee_2 = new Employee { FirstName = "Пётр", LastName = "Петров", Position = Development_Charc };
    Employee Employee_3 = new Employee { FirstName = "Иван", LastName = "Иванов", Position = Development_Java };
    Employee Employee_4 = new Employee { FirstName = "Светлана", LastName = "Сидорова", Position = Graphic_designer };
    Employee Employee_5 = new Employee { FirstName = "Анна", LastName = "Кузницова", Position = Development_Frontend };
    Employee Employee_6 = new Employee { FirstName = "Ян", LastName = "Ивин", Position = Design_iтterface };
    Employee Employee_7 = new Employee { FirstName = "Игорь", LastName = "Шерстюк", Position = Development_Java };
    Employee Employee_8 = new Employee { FirstName = "Антон", LastName = "Татыржа", Position = Sales_managerer };
    Employee Employee_9 = new Employee { FirstName = "Кирил", LastName = "Барано", Position = Marketer };
    Employee Employee_10 = new Employee { FirstName = "Константин", LastName = "Смерч", Position = Content_Specialist };
    Employee Employee_11 = new Employee { FirstName = "Арту", LastName = "Пирпжков", Position = Development_Frontend };
    db.Employees.AddRange(Employee_1, Employee_2, Employee_3, Employee_4, Employee_5, Employee_6, Employee_7, Employee_8, Employee_9, Employee_10, Employee_11);


    db.SaveChanges();

}

//--------------------------------------------------------------------------------------------------------

using (ApplicationContext_3 db = new ApplicationContext_3())
{
   

    Console.WriteLine("-----------Lazy loading-----------");

    var users = db.Employees.ToList();
    foreach (Employee user in users)



    Console.WriteLine($"{user.FirstName} {user.LastName}\nДолжность:  {user.Position?.PositionsName}\nОтдел: {user.Position?.Department?.DepartmentName} ");
    Console.WriteLine("----------------------"); // Для красоты
    
}