using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        string menuChoice;
        string newGoalChoice;
        string recordChoice;
        string loadedFile = "";
        string[] lines;
        string loadPoints;
        int currentPoints = 0;

        Goals goals = new Goals(loadedFile);
        SimpleGoal simpleGoal = new SimpleGoal(loadedFile);
        EternalGoal eternalGoal = new EternalGoal(loadedFile);
        ChecklistGoal checklistGoal = new ChecklistGoal(loadedFile);
        Console.Clear();
        while (true)
        {
            Console.Write("What would you like to do with your goals?\nNew, List, Load, Save, Record, Quit: ");
            menuChoice = Console.ReadLine().ToLower();

            if (menuChoice == "new")
            {
                while (true)
                {
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.Write("Which goal type would you like to set? type done when you are done\nSimple, Eternal or Checklist: ");
                    newGoalChoice = Console.ReadLine().ToLower();

                    if (newGoalChoice == "simple")
                    {
                        simpleGoal.CreateGoal();
                    }
                    else if (newGoalChoice == "eternal")
                    {
                        eternalGoal.CreateGoal();
                    }
                    else if (newGoalChoice == "checklist")
                    {
                        checklistGoal.CreateGoal();
                    }
                    else if (newGoalChoice == "done")
                    {
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid respose, please try again");
                    }
                }
            }
            else if (menuChoice == "list")
            {
                Thread.Sleep(500);
                Console.Clear();
                
                simpleGoal.DisplayGoals();
                eternalGoal.DisplayGoals();
                checklistGoal.DisplayGoals();
                Console.WriteLine($"Points: {currentPoints}");
                
                Thread.Sleep(500);
                Console.WriteLine();
            }
            else if (menuChoice == "load")
            {
                goals.FileSelect();
                loadedFile = goals.GetFile();
                lines = File.ReadAllLines(loadedFile);

                simpleGoal.LoadGoal(lines);
                eternalGoal.LoadGoal(lines);
                checklistGoal.LoadGoal(lines);
                loadPoints = lines[14];
                currentPoints = int.Parse(loadPoints);

                Thread.Sleep(500);
                Console.WriteLine("Load Successfully.");
                Console.WriteLine();
            }
            else if (menuChoice == "save")
            {
                goals.FileSelect();
                loadedFile = goals.GetFile();
                lines = File.ReadAllLines(loadedFile);

                string saveData = $"Goals:\nSimple Goal:\n{simpleGoal.GetSimpleGoal()}\nEternal Goal:\n{eternalGoal.GetEternalGoal()}\n-Point multiplier\n{eternalGoal.GetPointMultiplier()}\nChecklist Goal:\n{checklistGoal.GetChecklistGoal()}\n-Completed steps:\n{checklistGoal.GetTotalSteps()}\n-Number of steps:\n{checklistGoal.GetTotalSteps()}\nPoints:\n{currentPoints}";

                File.WriteAllText(loadedFile, string.Empty);
                File.AppendAllLines(loadedFile, new[] {saveData});

                Thread.Sleep(500);
                Console.WriteLine("Save Successfully.");
                Console.WriteLine();
            }
            else if (menuChoice == "record")
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.Write("Which goal type would you like to complete? type done when you are done\nSimple, Eternal or Checklist: ");
                    recordChoice = Console.ReadLine().ToLower();

                    if (recordChoice == "simple")
                    {
                        currentPoints += simpleGoal.RecordGoal();
                    }
                    else if (recordChoice == "eternal")
                    {
                        currentPoints += eternalGoal.RecordGoal();
                    }
                    else if (recordChoice == "checklist")
                    {
                        currentPoints += checklistGoal.RecordGoal();
                    }
                    else if (recordChoice == "done")
                    {
                        Thread.Sleep(500);
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid respose, please try again");
                    }
                }
            }
            else if (menuChoice == "quit")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid respose, please try again");
            }
        }
    }
}