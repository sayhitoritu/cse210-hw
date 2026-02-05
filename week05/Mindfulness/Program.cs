using System;

class Program
{
    // ===============================================
    // Creativity Feature Added:
    // This program keeps track of how many mindfulness
    // activities the user completes during the session.
    // After each activity, the total completed count is shown.
    // This exceeds the core requirements by adding progress tracking.
    // ===============================================
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("=== Mindfulness Program ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectingActivity();
            else if (choice == "3")
                activity = new ListingActivity();

            if (activity != null)
            {
                activity.Run();
            }
        }

        Console.WriteLine("Goodbye!");
    }
}

