using System;

public class Assignment
{
    public string Title { get; private set; }
    public DateTime DueDate { get; private set; }
    public bool IsCompleted { get; private set; }

    public Assignment(string title, DateTime dueDate)
    {
        Title = title;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void MarkAsComplete()
    {
        IsCompleted = true;
        Console.WriteLine($"Assignment '{Title}' marked as complete!");
    }

    public void Display()
    {
        string status = IsCompleted ? "Completed" : "Pending";
        Console.WriteLine($"Title: {Title} | Due: {DueDate.ToShortDateString()} | Status: {status}");
    }
}
