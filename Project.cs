using System;
using System.Windows.Forms;

namespace ph;

public class Project
{
    public string? Title { get; set; }
    public List<Task> Tasks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public void AddTask(Task task)
    {
        Tasks.Add(task);
    }

    public void RemoveTask(Task task)
    {
        Tasks.Remove(task);
    }
}
