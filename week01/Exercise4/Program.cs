using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Please enter a number (or 0 to stop): ");
            string answer = Console.ReadLine();
            userNumber = int.Parse(answer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average:F2}");

            int max = numbers[0];
            foreach (int n in numbers)            {
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"The maximum number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}