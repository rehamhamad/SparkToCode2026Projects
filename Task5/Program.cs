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


            //Task 3 - Browsing History Stack

            Stack<string> history = new Stack<string>();

            Console.WriteLine("\nEnter 3 website URLs:");

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Website " + i + ": ");
                string website = Console.ReadLine();
                history.Push(website);
            }

            history.Pop();

            Console.WriteLine("\nAfter pressing the Back button:");
            Console.WriteLine("You are now on: " + history.Peek());





            //Task 4 - Customer Service Queue

            Queue<string> customers = new Queue<string>();

            Console.WriteLine("Enter 3 customer names:");

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Customer " + i + ": ");
                string name = Console.ReadLine();
                customers.Enqueue(name);
            }

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("\nServing customer...");
            Console.WriteLine("Served: " + servedCustomer);


            //Task 5 - Array Grade Range

            int[] grades1 = new int[5];

            Console.WriteLine("Enter 5 grades:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Grade " + (i + 1) + ": ");
                grades1[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades1);

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += grades1[i];
            }

            double average = sum / 5.0;

            Console.WriteLine("\nGrade Results:");
            Console.WriteLine("Lowest Grade: " + grades1[0]);
            Console.WriteLine("Highest Grade: " + grades1[4]);
            Console.WriteLine("Average Grade: " + average);



            //Task 6 - Filtered Shopping List


            List<string> shoppingList = new List<string>();

            Console.WriteLine("Enter shopping items (type 'done' to finish):");

            while (true)
            {
                Console.Write("Item: ");
                string item = Console.ReadLine();

                if (item == "done")
                {
                    break;
                }

                shoppingList.Add(item);
            }

            Console.WriteLine("\nShopping List Before Removal:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }

            Console.Write("\nEnter an item to remove: ");
            string removeItem = Console.ReadLine();

            shoppingList.Remove(removeItem);

            Console.WriteLine("\nShopping List After Removal:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine("- " + item);
            }


            //Task 7 - High Score Podium

            List<int> scores = new List<int>();

            Console.WriteLine("Enter 5 game scores:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Score " + i + ": ");
                int score = int.Parse(Console.ReadLine());
                scores.Add(score);
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("\nHigh Score Podium:");

            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);



        }
    }
}
