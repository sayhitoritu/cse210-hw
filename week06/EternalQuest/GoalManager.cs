using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        // Menu loop will be implemented later
        Console.WriteLine("Eternal Quest program started.");
    }
}
