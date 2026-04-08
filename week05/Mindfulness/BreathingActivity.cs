using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by guiding your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = 0;
        while (time < GetDuration())
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);

            time += 8;
        }

        EndMessage();
    }
}