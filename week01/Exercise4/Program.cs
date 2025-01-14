using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) // if input is not 0 add input 
            {
                numbers.Add(input);
            }
        } while (input != 0); // whil input is 0 End Loop


            //seperate get sin
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }


            //seperate hard
        double average = (double)sum / numbers.Count;

        int max = numbers[0]; 


            //seperate get Max
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
