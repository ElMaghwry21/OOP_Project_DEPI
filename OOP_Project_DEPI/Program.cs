using System;
using System.Diagnostics;

namespace OOP_Project_DEPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10, "Programming C#");

            sub.CreateExam();

            Console.Clear();
            Console.WriteLine($"Starting Subject: {sub.SubjectName}\n");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            sub.SubjectExam.ShowExam();

            sw.Stop();
            Console.WriteLine($"\nTime Elapsed: {sw.Elapsed}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}