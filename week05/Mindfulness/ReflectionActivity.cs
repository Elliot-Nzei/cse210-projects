using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time you felt truly happy.",
        "Remember a moment when you helped someone.",
        "Recall an experience where you overcame a challenge."
    };

    public ReflectionActivity() : base("Reflection Exercise", "Reflect on positive past experiences.")
    {
    }

    public void Perform()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Think deeply about this for a few seconds...");
        ShowCountdown(Duration);
        Console.WriteLine("\nWell done! You've completed the reflection exercise.");
    }
}
