using Microsoft.EntityFrameworkCore;

using (ApplicationContext db = new ApplicationContext())
{
    // Получаем всех сотрудников вместе с их позициями и отделами
    var users = db.Employees
        .Include(u => u.Position) // Загружаем позиции сотрудников
            .ThenInclude(pos => pos.Department); // Загружаем отделы для позиций
    
    foreach (var user in users)
    {
        Console.WriteLine($"1");
        Console.WriteLine($"{user.FirstName} {user.LastName} - {user.Position?.PositionsName}");
        Console.WriteLine("----------------------"); // Для красоты
    }
}