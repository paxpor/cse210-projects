using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your firstname? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your lastname? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Hello {firstName} {lastName}!");
    }
}