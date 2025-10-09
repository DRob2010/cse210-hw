using System;

public class JournalEntry
{
    public List<string> _prompts = new List<string>();
    public string _currentPrompt;
    public string _writtenEntry;
    public string _fullEntry;

    public int SelectPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 9);

        return number;
    }

    public string NewEntry()
    {
        string Entry = Console.ReadLine();

        return Entry;
    }

    public void SaveEntry(string filePath, string entry)
    {
        File.AppendAllLines(filePath, new[] {entry});
    }
}