using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to your journal software!");

        bool journal = true;

        Journal journal1 = new Journal();
        JournalEntry journalEntry1 = new JournalEntry();
        journal1._filePath = "";

        journalEntry1._prompts.Add("What does “success” look like for you right now, and how has that definition changed over time?"); //(0)
        journalEntry1._prompts.Add("Describe a moment when you felt truly at peace. What contributed to that feeling?"); //(1)
        journalEntry1._prompts.Add("What habits or beliefs are you ready to let go of, and why?"); //(2)
        journalEntry1._prompts.Add("If you could design your ideal day from start to finish, what would it look like?"); //(3)
        journalEntry1._prompts.Add("Write a letter from your future self, five years from now. What advice or encouragement would they give you?"); //(4)
        journalEntry1._prompts.Add("Invent a new holiday that reflects something you value deeply. What traditions would it include?"); //(5)
        journalEntry1._prompts.Add("Who in your life has had the biggest impact on your personal growth, and how?"); //(6)
        journalEntry1._prompts.Add("What emotion do you find hardest to express, and what might help you open up more?"); //(7)
        journalEntry1._prompts.Add("What’s something you’ve changed your mind about recently, and what led to that shift?"); //(8)
        journalEntry1._prompts.Add("If you had a platform to speak to the world for 5 minutes, what message would you share?"); //(9)

        while (journal)
        {
            Console.Write("Would you like to do? (display, load, new, exit): ");
            string choice = Console.ReadLine();
            if (choice == "display")
            {
                if (File.Exists(journal1._filePath))
                {
                    journal1.DisplayJournal(journal1._filePath);
                }
                else
                {
                    Console.WriteLine("file not loaded. please load a file.");
                }

            }
            else if (choice == "load")
            {
                bool load = true;
                while (load)
                {
                    journal1._filePath = journal1.LoadFile();

                    if (File.Exists(journal1._filePath))
                    {
                        load = false;
                    }
                    else
                    {
                        Console.WriteLine("file not found. please use an existing file.");
                    }
                }
                    
            }
            else if (choice == "new")
            {
                if (File.Exists(journal1._filePath))
                {
                    journalEntry1._currentPrompt = journalEntry1._prompts[journalEntry1.SelectPrompt()];
                    Console.WriteLine(journalEntry1._currentPrompt);
                    journalEntry1._writtenEntry = journalEntry1.NewEntry();
                    journalEntry1._fullEntry = $"{DateTime.Now}, {journalEntry1._currentPrompt}: {journalEntry1._writtenEntry}";
                    journalEntry1.SaveEntry(journal1._filePath, journalEntry1._fullEntry);
                }
                else
                {
                    Console.WriteLine("file not loaded. please load a file.");
                }

            }
            else if (choice == "exit")
            {
                journal1.Exit();
            }
            else
            {
                Console.WriteLine("Invalid command, please try again.");
            }
        }

        
    }
}