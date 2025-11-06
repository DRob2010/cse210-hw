using System;

public class Listing : Activities
{
    private List<string> _listPrompts = new List<string>();
    private DateTime _currentTime;
    private DateTime _endTime;

    public Listing()
    {
        _listPrompts.Add("Who are people that you appreciate?");
        _listPrompts.Add("What are personal strengths of yours?");
        _listPrompts.Add("Who are people that you have helped this week?");
        _listPrompts.Add("When have you felt the Holy Ghost this month?");
        _listPrompts.Add("Who are some of your personal heroes?");
    }

    public void DuringListingActivity(int time)
    {
        Random randomGenerator = new Random();
        int listThink = randomGenerator.Next(0, 4);

        Console.Clear();
        Console.WriteLine("List as many responses to the prompt as you can.");
        Console.WriteLine();
        Console.WriteLine(_listPrompts[listThink]);
        Console.WriteLine();
        Console.Write("Press enter to start.");
        Console.ReadLine();

        _currentTime = DateTime.Now;
        _endTime = _currentTime.AddSeconds(time);
        
        while (_currentTime <= _endTime)
        {
            _currentTime = DateTime.Now;
            Console.Write(">");
            Console.ReadLine();
        }
    }
}