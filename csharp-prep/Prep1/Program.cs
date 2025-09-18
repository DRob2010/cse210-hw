using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!"); // equivlent to print in python. just write will write on the same line

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        
        // REFERENCE
        //string variable = "string"; // this is how you declare a variable in C#endregion
        //Console.WriteLine("hello " + variable + "."); // + puts them together
        //
        //Console.Write("What is your favorite color? ");
        //string favorite_color = Console.ReadLine(); // equivlent to input, we can use the write function to ask a question first
        //Console.WriteLine(favorite_color + ".");
        //
        //Console.Write("How old are you? ");
        //int age = int.Parse(Console.ReadLine()); //inputs string but converts to int
        //Console.WriteLine("You are " + age + " years old.");
        //
        //int a = 21;
        //int b = 7;
        //
        //int c = a + b; // adding ints
        //
        //Console.WriteLine($"{a} + {b} = {c}"); // use a $ to write with multiple variables instead of using +
        //
        //double example1 = 1.5;
        //float example2 = 1.5f; // use f after floats otherwise it thinks it's a double
        //
        //bool istrue = true; // Boolean
        //
        //if (istrue)
        //{
        //    Console.WriteLine("true"); // use a boolean for an if function
        //}
    }
}