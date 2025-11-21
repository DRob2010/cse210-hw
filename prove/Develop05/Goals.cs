using System;

public class Goals
{
    private string _loadedFile;

    public Goals(string loadedFile)
    {
        _loadedFile = loadedFile;
    }

    public virtual void CreateGoal()
    {
        
    }
    public virtual void DisplayGoals()
    {
        
    }
    public virtual void LoadGoal(string[] lines)
    {
        
    }
    public virtual int RecordGoal()
    {
        return 0;
    }
    public void FileSelect()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("What is your files name?");
            _loadedFile = Console.ReadLine();
            if (File.Exists(_loadedFile))
            {
                break;
            }
            else
            {
                Console.WriteLine("File not found, please type a valid file");
            }
        }
    }
    public string GetFile()
    {
        return _loadedFile;
    }
}