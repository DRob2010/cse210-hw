using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Resume davidResume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1991;
        job1._endYear = 2017;

        job2._company = "Google";
        job2._jobTitle = "Cybersecurity";
        job2._startYear = 1999;
        job2._endYear = 2020;

        davidResume._name = "David Sullivan";
        davidResume._jobs.Add(job1);
        davidResume._jobs.Add(job2);

        davidResume.Display();
    }
}