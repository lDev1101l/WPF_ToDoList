using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ToDoListApp.Data;

public class ToDoListContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }                      // Свойство Tasks представляет собой коллекцию объектов Task, которые будут храниться в базе данных.

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ToDoList.db");    // Настройка подключения к базе данных SQLite. База данных будет храниться в файле ToDoList.db.
    }
}
