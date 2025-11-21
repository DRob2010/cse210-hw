using System;

public class ChecklistGoal : Goals
{
    private int _awardPoints;
    private string _stringSteps;
    private string _stringCompletedSteps;
    private int _completedSteps;
    private int _numberOfSteps;
    private string _currentChecklistGoal;

    public ChecklistGoal(string loadedFile) : base(loadedFile)
    {
        _currentChecklistGoal = "Goal not set";
        _completedSteps = 0;
        _numberOfSteps = 0;
    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is your new Checklist Goal?");
        _currentChecklistGoal = Console.ReadLine();
        Console.WriteLine("How many steps are there to your goal?");
        _stringSteps = Console.ReadLine();
        _numberOfSteps = int.Parse(_stringSteps);
        _completedSteps = 0;

    }
    public override void DisplayGoals()
    {
        Console.WriteLine($"Checklist Goal: {_currentChecklistGoal}, {_completedSteps} out of {_numberOfSteps}");
    }
    public override void LoadGoal(string[] lines)
    {
        _currentChecklistGoal = lines[8];
        _stringCompletedSteps = lines[10];
        _completedSteps = int.Parse(_stringCompletedSteps);
        _stringSteps = lines[12];
        _numberOfSteps = int.Parse(_stringSteps);
    }
    public string GetChecklistGoal()
    {
        return _currentChecklistGoal;
    }
    public int GetCompletedSteps()
    {
        return _completedSteps;
    }
    public int GetTotalSteps()
    {
        return _numberOfSteps;
    }
    public override int RecordGoal()
    {
        if (_currentChecklistGoal == "Goal not set")
        {
            Console.WriteLine("This Goal is not set.");
            return 0;
        }
        else
        {
            _awardPoints = 100 / _numberOfSteps;
            Console.WriteLine($"Good job! You have been awarded with {_awardPoints} points.");
            _completedSteps += 1;

            if (_completedSteps == _numberOfSteps)
            {
            _currentChecklistGoal = "Goal not set";
            }
            return _awardPoints;
        }
    }
}