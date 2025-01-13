using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessNumber;

        do
        {
            Console.Write("Enter the magic number (1-100): ");
            magicNumber = int.Parse(Console.ReadLine());

            if (magicNumber < 1 || magicNumber > 100)
            {
                Console.WriteLine("Invalid input! The number must be between 1 and 100.");
            }
        } while (magicNumber < 1 || magicNumber > 100);

        do
        {
            do
            {
                Console.Write("Enter your guess (1-100): ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber < 1 || guessNumber > 100)
                {
                    Console.WriteLine("Invalid input! The guess must be between 1 and 100.");
                }
            } while (guessNumber < 1 || guessNumber > 100);

            if (guessNumber != magicNumber)
            {
                Console.WriteLine("Incorrect! Try again.");
            }

        } while (guessNumber != magicNumber);

        Console.WriteLine("Correct! You guessed the magic number.");
    }
}
