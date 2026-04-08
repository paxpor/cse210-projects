using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing", "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        Console.WriteLine("Get ready...");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        EndMessage();
    }
}