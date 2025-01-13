using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Score? ");
        string Scoreofuser = Console.ReadLine();

        int score = int.Parse(Scoreofuser);
        string letter = "";
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }        
        else if (score >= 60)
        {
            letter = "D";
        }        
        else 
        {
            letter = "F";
        }
        Console.WriteLine("Your score is" + " " + letter);
        if (score >= 70)
        {
            Console.WriteLine("Congratulations you Passed");
        }

        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}
