using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        bool programRunning = true;
        int time = 0;

        while (programRunning)
        {
            Console.WriteLine("What would you like to do?");
            Console.Write("Breathing, Reflection, Listing, or Quit: ");
            string menuOption = Console.ReadLine();
            menuOption = menuOption.ToLower();

            if (menuOption == "breathing")
            {
                Console.Clear();
                time = breathing.StartActivity();
                breathing.Animation();
                breathing.DuringBreathingActivity(time);
                breathing.EndActivity();
                breathing.Animation();
                breathing.RecordActivity(menuOption, time);
            }
            else if (menuOption == "reflection")
            {
                Console.Clear();
                time = reflection.StartActivity();
                reflection.Animation();
                reflection.DuringReflectionActivity(time);
                reflection.EndActivity();
                reflection.Animation();
                reflection.RecordActivity(menuOption, time);
            }
            else if (menuOption == "listing")
            {
                Console.Clear();
                time = listing.StartActivity();
                listing.Animation();
                listing.DuringListingActivity(time);
                listing.EndActivity();
                listing.Animation();
                listing.RecordActivity(menuOption, time);
            }
            else if (menuOption == "quit")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("1.");
                Console.WriteLine();
            }
        }
    }
}