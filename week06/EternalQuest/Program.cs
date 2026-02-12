using System;

/*
CREATIVITY:
- Added leveling system based on score
- Added bonus rewards for checklist completion
- Added visual level titles
- Implemented polymorphism fully via abstract Goal class
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
