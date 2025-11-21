using System;

public class SimpleGoal : Goals
{
    private string _currentSimpleGoal;

    public SimpleGoal(string loadedFile) : base(loadedFile)
    {
        _currentSimpleGoal = "Goal not set";
    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is your new Simple Goal?");
        _currentSimpleGoal = Console.ReadLine();
    }
    public override void DisplayGoals()
    {
        Console.WriteLine($"Simple Goal: {_currentSimpleGoal}");
    }
    public override void LoadGoal(string[] lines)
    {
        _currentSimpleGoal = lines[2];
    }
    public string GetSimpleGoal()
    {
        return _currentSimpleGoal;
    }
    public override int RecordGoal()
    {
        if (_currentSimpleGoal == "Goal not set")
        {
            Console.WriteLine("This Goal is not set.");
            return 0;
        }
        else
        {
            Console.WriteLine("Good job! You have been awarded with 100 points.");
            _currentSimpleGoal = "Goal not set";
            return 100;
        }
    }
}