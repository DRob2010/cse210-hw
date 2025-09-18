using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your Grade as a Percent? ");
        string grade_string = Console.ReadLine();
        int grade_number = int.Parse(grade_string);

        string letter_grade = " ";

        if (grade_number >= 90)
        {
            letter_grade = "A";
        }
        else if (grade_number <= 89 && grade_number >= 80)
        {
            letter_grade = "B";
        }
        else if (grade_number <= 79 && grade_number >= 70)
        {
            letter_grade = "C";
        }
        else if (grade_number <= 69 && grade_number >= 60)
        {
            letter_grade = "D";
        }
        else if (grade_number <= 59)
        {
            letter_grade = "F";
        }

        Console.WriteLine($"You got a {letter_grade}.");
    }

    // && is and, || is or, ! is not
    // int.Parse(_) turns _ string to int -> string userInput = Console.ReadLine(); / int number = int.Parse(userInput);
    // _.ToString() turns _ int to string -> string textVersion = number.ToString();

}