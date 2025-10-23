using System;

public class Scripture
{
    private List<string> _scripture = new List<string>();
    private List<int> _usedWords = new List<int>();

    public Scripture()
    {
        string sentence = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        _scripture = sentence.Split(" ").ToList();
    }

    public Scripture(string scripture)
    {
        string sentence = scripture;
        _scripture = sentence.Split(" ").ToList();
    }

    public bool RemoveWord(int word_number)
    {
        if (_usedWords.Contains(word_number))
        {
            if (_usedWords.Count() == _scripture.Count())
            {
                System.Environment.Exit(0);
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            char filler = '_';
            _usedWords.Add(word_number);
            _scripture[word_number] = new string (filler, _scripture[word_number].Count());
            return false;
        }
    }

    public List<string> ReturnScripture()
    {
        return _scripture;
    }
    
        public void WriteScripture()
    {
        foreach (string word in _scripture)
        Console.Write($"{word} ");
    }

}