using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq.Expressions;
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
            Console.WriteLine($"The sum of all whole numbers from 1 to " + N + " is "+ sum );

            ///////////////////////////////////////////////////////////////////

//            Task 3 - Multiplication Table
//Ask the user to enter a number, then print its multiplication table from 1 to 10 using a single for loop.
//Requirements:
//• Each line should show the full expression, e.g. "5 x 3 = 15".
//• Use only one loop - no nested loops


            Console.Write("Enter a number to print its multiplication table: ");
            int num = int.Parse(Console.ReadLine());
            for ( int i = 0; i <=10; i++)
            {
                int mul = i * num;
                Console.WriteLine(num + " x " + i + " = " + mul);
            }

            ///////////////////////////////////////////////////////////////////

//            Task 4 - Password Retry
//The correct password is fixed in the code as "Spark2026".Use a while loop to keep asking the user to enter the
//password until they type it correctly, then print "Access Granted".
//Requirements:
//• Use a while loop, since the number of attempts is unknown in advance.
//• Print "Incorrect password, try again" after each wrong attempt.

            Console.Write("Enter the password: ");
            string pass = Console.ReadLine();
            while (pass != "Spark2026")
            {
                Console.WriteLine("Incorrect password, try again");
                Console.Write("Enter the password: ");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Access Granted");










        }
    }
}
