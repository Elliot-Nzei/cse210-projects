using System;

class Program
{
    static void Main()
    {
        AssignmentManager manager = new AssignmentManager();

        while (true)
        {
            Console.WriteLine("\n=== Homework Manager ===");
            Console.WriteLine("1. Add Assignment");
            Console.WriteLine("2. Mark Assignment as Complete");
            Console.WriteLine("3. Show Assignments");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter assignment title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter due date (YYYY-MM-DD): ");
                    DateTime dueDate;
                    while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
                    {
                        Console.Write("Invalid date. Try again (YYYY-MM-DD): ");
                    }

                    manager.AddAssignment(title, dueDate);
                    break;

                case "2":
                    Console.Write("Enter assignment title to mark as complete: ");
                    string completeTitle = Console.ReadLine();
                    manager.CompleteAssignment(completeTitle);
                    break;

                case "3":
                    manager.ShowAssignments();
                    break;

                case "4":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
