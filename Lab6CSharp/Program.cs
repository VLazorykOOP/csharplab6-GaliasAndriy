using System;

namespace Lab6CSharp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab6 C# ");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("1. Final exams. Refactored");
        Console.WriteLine("2. Goods. Interface");
        Console.WriteLine("-----------------------------------------------");


        try
        {
            Console.Write("Choose a task : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (choice)
            {
                case 1:
                    TasksUsage.Task1();
                    Console.WriteLine("");
                    break;
                case 2:
                    TasksUsage.Task2();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Task not found.");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
