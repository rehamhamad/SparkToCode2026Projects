using Microsoft.VisualBasic;
using System.Drawing;

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

            //Task 4 - Voting Eligibility

            //Ask the user to enter their age and whether they hold a valid national ID(yes/ no). Determine whether the person is
            //eligible to vote.
            //Requirements:
            //• A person is eligible only if their age is 18 or above AND they hold a valid ID.
            //• Convert the yes / no answer into a bool value before using it in your condition.
            //• Use the logical AND operator (&&) in your if condition

            Console.WriteLine("Task 4 - Voting Eligibility ");
            Console.WriteLine("Enter Your Age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you have a valid national ID? (yes/no): ");
            string id = Console.ReadLine().ToLower();   // Read and Convert input to lowercase

            bool value;         // create a boolean variable to store the result of the ID check
            if (id == "yes")
            {
                value = true;
            }
            else if (id == "no")
            {
                value = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
                value = false;  // set value to false for invalid input
            }

            if (Age >= 18 && value == true)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 5 - Grade Letter Lookup

            //Ask the user to enter a single character representing a grade('A', 'B', 'C', 'D', or 'F') and print the meaning of that
            //grade using a switch-case statement.
            //Requirements:
            //• Map: A → Excellent, B → Very Good, C → Good, D → Pass, F → Fail.
            //• Print "Invalid grade" for any other character using the default case

            Console.WriteLine("\nEnter Your Grade (A, B, C, D, or F): ");
            char grade = char.Parse(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 6 - Temperature Converter
            //Ask the user to enter a temperature in Celsius, convert it to Fahrenheit, then classify the weather based on the
            //Celsius value.
            //Requirements:
            //• Conversion formula: F = (C * 9 / 5) + 32.
            //• Classification: below 10 → "Cold", 10 to 30 → "Mild", above 30 → "Hot".
            //• Print the converted Fahrenheit value and the weather classification

            Console.WriteLine("Enter the temperature in Celsius: ");
            float Ctemp = float.Parse(Console.ReadLine());

            float Ftemp = (Ctemp * 9 / 5) + 32;
            if (Ftemp < 10)
            {
                Console.WriteLine("The Temperature in Fehrenhite is: " + Ftemp + " The weather is Cold");
            }
            else if (Ftemp >= 10 && Ftemp <= 30)
            {
                Console.WriteLine("The Temperature in Fehrenhite is: " + Ftemp + " The weather is Mild");
            }
            else
            {
                Console.WriteLine("The Temperature in Fehrenhite is: " + Ftemp + " The weather is Hot");
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


























        }
    }
}
