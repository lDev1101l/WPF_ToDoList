using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoListApp;

public class Task
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? CompletedAt { get; set; }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
        CompletedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Id}: {Title} - {(IsCompleted ? "Completed" : "Pending")}";
    }
}
