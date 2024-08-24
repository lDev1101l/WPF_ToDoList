using System;
using System.Collections.Generic;
using System.Linq;
using ToDoListApp.Data;

namespace ToDoListApp;

public class ToDoList
{
    private readonly ToDoListContext _context;

    public ToDoList()
    {
        _context = new ToDoListContext();
        _context.Database.EnsureCreated();
    }

    public void AddTask(string title, string description)
    {
        var task = new Task { Title = title, Description = description };
        _context.Tasks.Add(task);
        _context.SaveChanges();
    }

    public void RemoveTask(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task != null)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }

    public void MarkTaskAsCompleted(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task != null)
        {
            task.MarkAsCompleted();
            _context.SaveChanges();
        }
    }

    public List<Task> GetAllTasks()
    {
        return _context.Tasks.ToList();
    }

    public void ShowAllTasks()
    {
        foreach (var task in GetAllTasks())
        {
            Console.WriteLine(task);
        }
    }
}
