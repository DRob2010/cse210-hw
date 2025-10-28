using System;

public class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment()
    {
        _studentName = "Maria";
        _topic = "Linear Lines";
    }
    public WrittingAssignment(string studentName, string topic, string title)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }

    public string GetWrittingInformation()
    {
        return _title + " by " + _studentName;
    }
}