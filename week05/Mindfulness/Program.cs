using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Mindfulness Program ===");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Perform();
                    break;

                case "2":
                    new ReflectionActivity().Perform();
                    break;

                case "3":
                    new ListingActivity().Perform();
                    break;

                case "4":
                    Console.WriteLine("Exiting... Stay mindful!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
