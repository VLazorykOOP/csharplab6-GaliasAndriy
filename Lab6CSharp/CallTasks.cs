namespace Lab6CSharp
{
    public class TasksUsage
    {
        public static void Task1()
        {
            IUserInterface1 exam = new Exam("Modul Test 1", "Ruby", new DateTime(2024, 4, 24, 12, 50, 0), 12, 50);
            IUserInterface1 finalExam = new FinalExam("Final Exam", "Physics", new DateTime(2024, 5, 20, 10, 0, 0), 70, 10, 0);
            IUserInterface2 quiz = new Quiz("Weekly Quiz", "System Analysis", 10);
            
            Console.WriteLine("Task 1: ");
            exam.Show();
            Console.WriteLine();

            finalExam.Show();
            Console.WriteLine();

            quiz.Show();
        }

        public static void Task2()
        {
            IProduct[] inventory = new IProduct[]
            {
                new Toy("Lego", 100, "LEGO Group", "plastic", 5, "kids"),
                new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 200, "Bloomsbury", 10, "kids"),
                new SportsEquipment("Football", 79, "Nike", 12),
                new Toy("Car: Ford Mustang 1967", 10, "Hot Wheels", "metal", 3, "boys")
            };

            Console.WriteLine("Full information from the inventory:");
            foreach (var product in inventory)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
