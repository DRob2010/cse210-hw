using System;

public class EternalGoal : Goals
{
    private string _stringpointMultiplier;
    private int _pointMultiplier;
    private int _awardPoints;
    private string _currentEternalGoal;

    public EternalGoal(string loadedFile) : base(loadedFile)
    {
        _currentEternalGoal = "Goal not set";
        _pointMultiplier = 1;
    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is your new Eternal Goal?");
        _currentEternalGoal = Console.ReadLine();
        _pointMultiplier = 1;
    }
    public override void DisplayGoals()
    {
        Console.WriteLine($"Eternal Goal: {_currentEternalGoal}, Point Multiplier: x{_pointMultiplier}");
    }
    public override void LoadGoal(string[] lines)
    {
        _currentEternalGoal = lines[4];
        _stringpointMultiplier = lines[6];
        _pointMultiplier = int.Parse(_stringpointMultiplier);
    }
    public string GetEternalGoal()
    {
        return _currentEternalGoal;
    }
    public int GetPointMultiplier()
    {
        return _pointMultiplier;
    }
    public override int RecordGoal()
    {
        if (_currentEternalGoal == "Goal not set")
        {
            Console.WriteLine("This Goal is not set.");
            return 0;
        }
        else
        {
            _awardPoints = 10 * _pointMultiplier;
            Console.WriteLine($"Good job! You have been awarded with {_awardPoints} points.");
            if (_pointMultiplier < 5)
            {
                _pointMultiplier += 1;
            }
            return _awardPoints;
        }    
    }
}