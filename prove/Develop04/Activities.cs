using System;
using System.Diagnostics;

public class Activities
{
    private string _startMessage;
    private string _endMessage;
    private bool _animation;
    private int _loadTime;
    private string _filePath;
    private string _entry;

    public Activities()
    {
        _startMessage = "Get ready for your activity.";
        _endMessage = "Good job";
        _filePath = "mindfulness.csv";
    }

    public int StartActivity()
    {
        Console.WriteLine(_startMessage);
        Console.WriteLine();

        Console.Write("How log would you like to do this activity for? ");
        string timeString = Console.ReadLine();
        int timeInt = int.Parse(timeString);

        return timeInt;
    }

    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine(_endMessage);
        Console.WriteLine();
        Console.WriteLine("You have completed this activity");
        Thread.Sleep(3000);
    }

    public void RecordActivity(string currentActivity, int time)
    {
        _entry = $"{DateTime.Now}, {currentActivity}, for {time} seconds";
        File.AppendAllLines(_filePath, new[] {_entry});
    }
    
    public void Animation()
    {
        _animation = true;
        _loadTime = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(3, 7);
        Console.Clear();
        while (_animation)
        {
            Console.Write("\\");
            Thread.Sleep(150);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(150);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(150);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(150);

            Console.Write("\b \b"); // Erase the + character

            _loadTime += 1;
            if (_loadTime == number)
            {
                _animation = false;
            }
        }
    }
}