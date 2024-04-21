using System;

namespace Lab6CSharp
{
    public class Test : IUserInterface1
    {
        protected string testName;
        protected string subject;

        public Test(string testName, string subject)
        {
            this.testName = testName;
            this.subject = subject;
        }

        public Test()
        {
            Console.WriteLine("Test constructor without parameters called.");
        }

        public Test(string testName)
        {
            Console.WriteLine("Test constructor with testName parameter called.");
            this.testName = testName;
        }

        ~Test()
        {
            Console.WriteLine("Test destructor called.");
        }

        public virtual void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Test Name: {testName}");
            Console.ResetColor();
            Console.WriteLine($"Subject: {subject}");
        }
    }
}
