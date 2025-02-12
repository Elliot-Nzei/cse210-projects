using System;
using System.Collections.Generic;

public class AssignmentManager
{
    private List<Assignment> assignments;

    public AssignmentManager()
    {
        assignments = new List<Assignment>();
    }

    public void AddAssignment(string title, DateTime dueDate)
    {
        assignments.Add(new Assignment(title, dueDate));
        Console.WriteLine($"Added new assignment: {title}");
    }

    public void CompleteAssignment(string title)
    {
        Assignment assignment = assignments.Find(a => a.Title == title);
        if (assignment != null)
        {
            assignment.MarkAsComplete();
        }
        else
        {
            Console.WriteLine("Assignment not found.");
        }
    }

    public void ShowAssignments()
    {
        if (assignments.Count == 0)
        {
            Console.WriteLine("No assignments available.");
            return;
        }

        Console.WriteLine("\nList of Assignments:");
        foreach (var assignment in assignments)
        {
            assignment.Display();
        }
    }
}
