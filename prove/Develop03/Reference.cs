using System;

public class Reference
{
    private string _reference;

    public Reference()
    {
        _reference = "1 Nephi 3:7";
    }

    public Reference(string reference)
    {
        _reference = reference;
    }
    
    public void GetReference()
    {
        Console.WriteLine(_reference);
    }
}