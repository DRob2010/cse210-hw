using System;

public class Reflection : Activities
{
    private List<string> _thinkPrompts = new List<string>();
    private List<string> _reflectPrompts = new List<string>();
    private int _seconds;

    public Reflection()
    {
        _thinkPrompts.Add("Think of a time when you stood up for someone else.");
        _thinkPrompts.Add("Think of a time when you did something really difficult.");
        _thinkPrompts.Add("Think of a time when you helped someone in need.");
        _thinkPrompts.Add("Think of a time when you did something truly selfless.");

        _reflectPrompts.Add("Why was this experience meaningful to you?");
        _reflectPrompts.Add("Have you ever done anything like this before?");
        _reflectPrompts.Add("How did you get started?");
        _reflectPrompts.Add("How did you feel when it was complete?");
        _reflectPrompts.Add("What made this time different than other times when you were not as successful?");
        _reflectPrompts.Add("What is your favorite thing about this experience?");
        _reflectPrompts.Add("What could you learn from this experience that applies to other situations?");
        _reflectPrompts.Add("What did you learn about yourself through this experience?");
        _reflectPrompts.Add("How can you keep this experience in mind in the future?");
    }

    public void DuringReflectionActivity(int time)
    {
        Console.Clear();
        Random randomGenerator = new Random();
        int thinkInt = randomGenerator.Next(0, 3);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(_thinkPrompts[thinkInt]);
        Console.WriteLine();
        Console.WriteLine("Press enter to continue. Ponder on the next prompt.");
        Console.ReadLine();

        Console.Clear();
        int ponderInt = randomGenerator.Next(0, 8);
        Console.WriteLine(_reflectPrompts[ponderInt]);
        _seconds = time * 1000;
        Thread.Sleep(_seconds);
    }
}