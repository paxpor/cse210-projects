using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = GetUserName();
        int userNumber = GetUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("Welcome to the program that squares a number you provide.");
    }
    static string GetUserName()
    {
        Console.WriteLine("What is your name? ");
        return Console.ReadLine();
    }
    static int GetUserNumber()
    {
        Console.WriteLine("Please enter a number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int originalNumber, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of {originalNumber} is {squaredNumber}.");
    }
}