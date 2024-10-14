using System;

namespace ph;

public class Task
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Deadline { get; set; }
    public string? Priority { get; set; } // High, Medium, Low
    public List<Task> Dependencies { get; set; } = new List<Task>(); // Dependent tasks
    public bool IsComplete { get; set; }
}
