using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fractions test1 = new Fractions();
        string fraction1 = test1.GetFractionString();
        Console.WriteLine(fraction1);
        double decimal1 = test1.GetDecimalValue();
        Console.WriteLine(decimal1);

        Fractions test2 = new Fractions(5);
        string fraction2 = test2.GetFractionString();
        Console.WriteLine(fraction2);
        double decimal2 = test2.GetDecimalValue();
        Console.WriteLine(decimal2);
        
        Fractions test3 = new Fractions(2, 5);
        string fraction3 = test3.GetFractionString();
        Console.WriteLine(fraction3);
        double decimal3 = test3.GetDecimalValue();
        Console.WriteLine(decimal3);

        Fractions test4 = new Fractions();
        test4.SetTop(7);
        test4.SetBottom(3);
        int top4 = test4.GetTop();
        Console.WriteLine(top4);
        int bottom4 = test4.GetBottom();
        Console.WriteLine(bottom4);
        string fraction4 = test4.GetFractionString();
        Console.WriteLine(fraction4);
        double decimal4 = test4.GetDecimalValue();
        Console.WriteLine(decimal4);
    }
}