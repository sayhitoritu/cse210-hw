using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful to you?",
        "How did you feel afterward?",
        "What did you learn from this?",
        "What strengths did you show?",
        "How can you use this experience again?"
    };

    private Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting",
        "This activity helps you reflect on times when you showed strength and resilience.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(GetRandomPrompt());

        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("\n" + GetRandomQuestion());
            ShowSpinner(4);
        }

        DisplayEndingMessage();
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
