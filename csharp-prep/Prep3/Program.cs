using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("I'm thinking of a number between 1 and 100");
        int number_of_guesses = 0;
        bool guessing = true;

        while (guessing)
        {

            number_of_guesses += 1;
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int int_guess = int.Parse(guess);

            if (int_guess == number)
            {
                Console.WriteLine("You Guessed it!");
                Console.WriteLine($"You guessed {number_of_guesses} times");
                guessing = false;
            }
            else if (int_guess <= number)
            {
                Console.WriteLine("Higher!");
            }
            else if (int_guess >= number)
            {
                Console.WriteLine("Lower!");
            }
        }
    }
}

// Do While