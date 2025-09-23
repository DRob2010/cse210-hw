using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string typed_name = PromptUserName();
        int favorite_number = PromptUserNumber();
        int birth_year;
        PromtUserBirthYear(out birth_year);
        int squared_favorite_number = SquareNumber(favorite_number);
        DisplayResult(typed_name, squared_favorite_number, birth_year);

        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string typed_name = Console.ReadLine();
            return typed_name;
        }

        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string string_number = Console.ReadLine();
            int favorite_number = int.Parse(string_number);
            return favorite_number;
        }
        void PromtUserBirthYear(out int birth_year)
        {
            Console.Write("Please enter the year you were born: ");
            string string_year = Console.ReadLine();
            birth_year = int.Parse(string_year);
        }

        int SquareNumber(int number)
        {
            int squared_favorite_number = number * number;
            return squared_favorite_number;
        }

        void DisplayResult(string typed_name, int squared_favorite_number, int birth_year)
        {
            Console.WriteLine($"{typed_name}, the square of your number is {squared_favorite_number}");
            int how_old = 2025 - birth_year;
            Console.WriteLine($"{typed_name}, you will turn {how_old} this year.");
        }
    }
}