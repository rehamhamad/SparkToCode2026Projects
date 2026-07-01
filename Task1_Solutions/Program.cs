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

            //Task 2 - Rectangle Calculator

            //Ask the user to enter the length and width of a rectangle as input, then calculate and display its area and perimeter.
            //Requirements:
            //• Read both values using Console.ReadLine and convert them to an appropriate numeric type.
            //• Area = length * width, Perimeter = 2 * (length + width).
            //• Print both results with descriptive labels.

            Console.WriteLine("Task 2 : Reactangle Calculator");
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the triangle: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine("Area = " + area + "\nPerimeter = " + perimeter + "\n");


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 3 - Even or Odd Checker


            //Ask the user to enter a whole number, then determine whether it is even or odd and print the result.
            // Requirements:
            //• Use the modulus operator (%) to check divisibility by 2.
            //• Use an if-else statement to decide which message to print.

            Console.WriteLine("Task 3 - Even or Odd Checker");
            Console.Write("Enter Your Number: ");
            int num = int.Parse(Console.ReadLine());
            int check = num % 2;
            if (check == 0)
            {
                Console.WriteLine("The number is even \n");
            }
            else
            {
                Console.WriteLine("The number is odd \n");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        }
    }
}
