using System;

public class Assignment
{
    private protected string _studentName;
    private protected string _topic;

    public Assignment()
    {
        _studentName = "Maria";
        _topic = "Linear Lines";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return _studentName + ", " + _topic;
    }
}