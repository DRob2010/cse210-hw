using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        bool tool = true;
        bool sameWord;
        Word word1 = new Word();

        Scripture scripture1 = new Scripture();
        Reference reference1 = new Reference();
        Console.Clear();

        while (tool)
        {
            reference1.GetReference();
            scripture1.WriteScripture();

            Console.ReadLine();
            Console.Clear();
            sameWord = true;

            while (sameWord)
            {
                sameWord = scripture1.RemoveWord(word1.SetWord(scripture1.ReturnScripture()));
            }
        }

    }
}