using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Task 1 - Countdown Timer
            //Ask the user to enter a starting number, then print a countdown from that number down to 1 using a for loop, and
            //print "Liftoff!" after the loop ends.
            //Requirements:
            //• Use a for loop that decreases the counter on each iteration.
            //• Print one number per line during the countdown.

            Console.Write("Enter you starting number for the countdown: ");
            int start = int.Parse(Console.ReadLine());
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");

            ///////////////////////////////////////////////////////////////////

            //            Task 2 - Sum of Numbers 1 to N
            //Ask the user to enter a positive whole number N, then use a for loop to calculate the sum of all whole numbers from
            //1 to N, and print the final sum.
            //Requirements:
            //• Use a variable initialized to 0 to accumulate the total inside the loop.
            //• Print the final sum only once, after the loop has finished.


            Console.Write("Enter a positive whole number: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1 ; i <= N; i++) {
                sum += i;
            }
            Console.WriteLine($"The sum of all whole numbers from 1 to" + N + " is "+ sum );

            ///////////////////////////////////////////////////////////////////





        }
    }
}
