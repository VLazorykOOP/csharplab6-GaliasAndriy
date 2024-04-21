using System;

namespace Lab6CSharp
{
    // Define the IUserInterface1 interface
    public interface IUserInterface1
    {
        void Show();
    }
    public class FinalExam : Exam, IUserInterface1
    {
        protected int passingScore;

        public FinalExam(string testName, string subject, DateTime examDate, int passingScore) 
            : base(testName, subject, examDate)
        {
            this.passingScore = passingScore;
        }

        // Additional constructor
        public FinalExam(string testName, string subject, DateTime examDate, int passingScore, int hours, int minutes) 
            : base(testName, subject, examDate, hours, minutes)
        {
            this.passingScore = passingScore;
        }

        ~FinalExam()
        {
            Console.WriteLine("FinalExam destructor called.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Passing Score: {passingScore}");
        }
    }
}
