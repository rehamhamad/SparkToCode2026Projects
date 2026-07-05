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
        }
    }
}
