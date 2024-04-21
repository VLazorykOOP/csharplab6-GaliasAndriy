using System;

namespace Lab6CSharp
{
    public class Exam : Test, IUserInterface1
    {
        protected DateTime examDate;

        public Exam(string testName, string subject, DateTime examDate) : base(testName, subject)
        {
            this.examDate = examDate;
        }

        // Additional constructor
        public Exam(string testName, string subject, DateTime examDate, int hours, int minutes) 
            : base(testName, subject)
        {
            this.examDate = new DateTime(examDate.Year, examDate.Month, examDate.Day, hours, minutes, 0);
        }

        ~Exam()
        {
            Console.WriteLine("Exam destructor called.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Exam Date: {examDate}");
        }
    }
}