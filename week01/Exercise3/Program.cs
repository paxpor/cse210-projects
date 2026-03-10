using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != randomNumber)
        {
            Console.WriteLine("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess < randomNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number!");
            }
        }
    }
}