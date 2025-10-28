using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Luke", "Geology");

        MathAssignment mathAssignment1 = new MathAssignment("David", "Graphing", "Section 7", "Problems 3-8");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WrittingAssignment writtingAssignment1 = new WrittingAssignment("David", "Intro Programing", "How to code");
        Console.WriteLine(writtingAssignment1.GetSummary());
        Console.WriteLine(writtingAssignment1.GetWrittingInformation());

    }
}