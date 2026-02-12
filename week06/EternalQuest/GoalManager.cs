using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine($"You have {_score} points.");
            DisplayLevel();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select choice: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));

        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved successfully.");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
            return;

        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            if (line.StartsWith("SimpleGoal"))
                _goals.Add(new SimpleGoal("LoadedGoal", "", 100));

            else if (line.StartsWith("EternalGoal"))
                _goals.Add(new EternalGoal("LoadedGoal", "", 100));

            else if (line.StartsWith("ChecklistGoal"))
                _goals.Add(new ChecklistGoal("LoadedGoal", "", 100, 5, 500));
        }

        Console.WriteLine("Loaded successfully.");
    }

    private void DisplayLevel()
    {
        if (_score >= 5000)
            Console.WriteLine("🏆 Level: Master Disciple");
        else if (_score >= 2000)
            Console.WriteLine("⭐ Level: Advanced Seeker");
        else if (_score >= 500)
            Console.WriteLine("🌟 Level: Growing Saint");
        else
            Console.WriteLine("✨ Level: Beginner");
    }
}

