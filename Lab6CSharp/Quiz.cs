using System;

namespace Lab6CSharp
{
    public interface IUserInterface2
    {
        void Show();
    }
    public class Quiz : Test, IUserInterface2
    {
        // Define the IUserInterface1 interface
        protected int numberOfQuestions;

        public Quiz(string testName, string subject, int numberOfQuestions) : base(testName, subject)
        {
            this.numberOfQuestions = numberOfQuestions;
        }

        // Additional
        public Quiz(string testName, int numberOfQuestions) : base(testName)
        {
            Console.WriteLine("Quiz constructor with testName parameter called.");
            this.numberOfQuestions = numberOfQuestions;
        }

        ~Quiz()
        {
            Console.WriteLine("Quiz destructor called.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Number of Questions: {numberOfQuestions}");
        }
    }
}
