using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference

            //Ask the user to enter two numbers, subtract the second from the first, and use a Math function to make sure the
            //result is always displayed as a positive value, no matter the order entered.
            //Requirements:
            //• Use Math.Abs on the subtraction result.
            //• Print the final positive difference with a clear label



            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int difference = Math.Abs(firstNumber - secondNumber);

            Console.WriteLine("Positive Difference: " + difference);

            ////////////////////////////////////////////////////////////

//            Task 2 - Power & Root Explorer
//Ask the user to enter a number, then print its square(power of 2) and its square root.
//Requirements:
//• Use Math.Pow to calculate the square.
//• Use Math.Sqrt to calculate the square root.
//• Print both results clearly labeled.

            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square: " + square);
            Console.WriteLine("Square Root: " + squareRoot);




        }
    }
}
