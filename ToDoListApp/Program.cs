using System;

namespace ToDoListApp;

class Program
{
    static void Main(string[] args)
    {
        var toDoList = new ToDoList();

        toDoList.AddTask("Buy groceries", "Milk, Bread, Cheese");
        toDoList.AddTask("Learn C#", "Work on ToDo List project");

        Console.WriteLine("All Tasks:");
        toDoList.ShowAllTasks();

        toDoList.MarkTaskAsCompleted(1);

        Console.WriteLine("\nTasks after marking task 1 as completed:");
        toDoList.ShowAllTasks();
    }
}