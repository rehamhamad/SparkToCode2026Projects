namespace Task1_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Easy 5 Tasks 

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 1: Personal Info Card 

            //Declare variables to store a person's name (string), age (int), height in meters (double), and whether they are a
            //student(bool).Assign them values directly in the code(no input needed), then print them as a single formatted info
            //card.
            //Requirements:
            //• Use at least four variables with four different data types.
            //• Print each value on its own line with a clear label.
            //Sample output: Name: Sara, Age: 21, Height: 1.65, Student: True

            Console.WriteLine("Task 1 : Personal Info Card");
            string name = "Reham";
            int age = 22;
            double hight = 1.54;
            bool isStudent = true;

            Console.WriteLine("Name:" + name + ", Age:" + age + ", Hight:" + hight + ", Student:" + isStudent + "\n");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
