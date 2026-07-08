namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            // Task 1 - Fixed Grades Array
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nStudent Grades:");

           
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            //Task 2 - Dynamic To-Do List
            List<string> tasks = new List<string>();

            Console.WriteLine("\nEnter 5 tasks:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Task " + (i + 1) + ": ");
                string task = Console.ReadLine();
                tasks.Add(task);
            }

            Console.WriteLine("\nTo-Do List:");

            foreach (string task in tasks)
            {
                Console.WriteLine("- " + task);
            }
        }
    }
}
