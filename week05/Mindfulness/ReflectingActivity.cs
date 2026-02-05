using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you felt peace."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What would you do again?"
    };

    private Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting",
               "This activity helps you reflect on meaningful moments.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(4);
        }

        DisplayEndingMessage();
        Console.ReadKey();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}
