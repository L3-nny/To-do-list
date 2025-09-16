using System;

public class TaskList
{
    //attributes
    public string Title {get; set;}
    public string Description {get; set;}
    public int Priority {get; set;}
    public bool IsCompleted {get; private set;}

    //constructor
    public void TaskList(string title, string description, int priority)
    {
        Title = title;
        Description = description;
        Priority = priority;
        IsCompleted = false;
    }

    //methods
    public void MarkComplete()
    {
        IsCompleted = true;
        Console.WriteLine($"{Title} is now completed");
    }

    public void DisplayTask()
    {
        Console.WriteLine($"Title : {Title}" + $"Status: {IsCompleted}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Priority : {Priority}");

    }
}

class Program
{
    static void Main()
    {
        TaskList taskItem1 = new TaskList("School work", "Finish assignment on Power Electronics", 3);
        TaskList.DisplayTask();
    }
      
}