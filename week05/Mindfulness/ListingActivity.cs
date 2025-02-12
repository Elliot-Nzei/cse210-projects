using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "List things you're grateful for.",
        "List people who have influenced you positively.",
        "List your recent achievements."
    };

    public ListingActivity() : base("Listing Exercise", "Write down positive things related to a prompt.")
    {
    }

    public void Perform()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You have a few seconds to list as many as you can. Start now!");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response: ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items. Great job!");
    }
}
