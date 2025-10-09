using System;

public class Journal
{
    public List<string> _Entries = new List<string>();
    public string _filePath;

    

    public void DisplayJournal(string _filePath)
    {
        string data = File.ReadAllText(_filePath);
        Console.WriteLine(data);
    }

    public string LoadFile()
    {
        Console.Write("What is your file's name?: ");
        string filePath = Console.ReadLine();
        return filePath;
    }

    public void Exit()
    {
        System.Environment.Exit(0);
    }
}