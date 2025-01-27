// Program.cs
using System;

public class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nJournal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    Random random = new Random();
                    int randomIndex = random.Next(prompts.Length);
                    string randomPrompt = prompts[randomIndex];

                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    journal.AddEntry(randomPrompt, response);
                    Console.WriteLine("Entry saved!");
                    break;

                case "2":
                    // Display journal
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Save journal to file
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved!");
                    break;

                case "4":
                    // Load journal from file
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    if (File.Exists(loadFilename))
                    {
                        journal.LoadFromFile(loadFilename);
                        Console.WriteLine("Journal loaded!");
                    }
                    else
                    {
                        Console.WriteLine("File does not exist.");
                    }
                    break;

                case "5":
                    // Exit the program
                    Console.WriteLine("Exiting the Journal Program.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
