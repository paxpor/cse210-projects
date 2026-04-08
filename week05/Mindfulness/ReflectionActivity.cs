using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made this different?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection", "This activity helps you reflect on your strengths.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        Console.WriteLine("Think about it...");
        ShowSpinner(5);

        int time = 0;

        while (time < GetDuration())
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(4);
            time += 4;
        }

        EndMessage();
    }
}