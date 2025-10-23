using System;
using System.Data.SqlTypes;

public class Word
{
    private string _word;

    public Word()
    {
        _word = "behold";
    }

    public Word(string word)
    {
        _word = word;
    }

    public int SetWord(List<string> scripture)
    {
        Random randomGenerator = new Random();
        int word_number = randomGenerator.Next(0, scripture.Count());

        return word_number;
    }

    public void GetWord()
    {
        
    }
}