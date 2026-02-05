using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate:",
        "List things you are grateful for:",
        "List personal strengths:"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing",
               "This activity helps you list positive things in your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        ShowCountDown(5);

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
        Console.ReadKey();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}
