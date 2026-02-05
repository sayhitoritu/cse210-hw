using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
               "This activity helps you relax by guiding breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.Write("\nBreathe out... ");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
        Console.ReadKey();
    }
}
