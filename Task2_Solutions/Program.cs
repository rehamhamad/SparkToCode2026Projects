using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Timers;
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

            Console.Write("\nEnter you starting number for the countdown: ");
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


            Console.Write("\nEnter a positive whole number: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of all whole numbers from 1 to " + N + " is " + sum);

            ///////////////////////////////////////////////////////////////////

            //            Task 3 - Multiplication Table
            //Ask the user to enter a number, then print its multiplication table from 1 to 10 using a single for loop.
            //Requirements:
            //• Each line should show the full expression, e.g. "5 x 3 = 15".
            //• Use only one loop - no nested loops


            Console.Write("\nEnter a number to print its multiplication table: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
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

            Console.Write("\nEnter the password: ");
            string pass = Console.ReadLine();
            while (pass != "Spark2026")
            {
                Console.WriteLine("Incorrect password, try again");
                Console.Write("Enter the password: ");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Access Granted");

            ///////////////////////////////////////////////////////////////////


            //            Task 5 - Number Guessing Game
            //Fix a secret number in the code(for example, 42).Use a do -while loop to let the user keep guessing the number,
            //printing "Too high" or "Too low" after each wrong guess. When the user guesses correctly, print how many attempts
            //it took.
            //Requirements:
            //• Use a do -while loop, since the user must be allowed to guess at least once.
            //• Use a counter variable to track the number of attempts.
            //• Use if / else if / else to compare the guess with the secret number

            int secretNumber = 42;
            int gussCount = 0;
            int guss;
            do
            {
                Console.WriteLine("\nGuess the secret number (between 1 and 100): ");
                guss = int.Parse(Console.ReadLine());

                gussCount++;

                if (guss > secretNumber)
                {
                    Console.WriteLine("Too high");

                }
                else if (guss < secretNumber)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Congratulations! ");

                }
            }
            while (guss != secretNumber);
            Console.WriteLine("you guessed the secret number in " + gussCount + " attempts.");

            ///////////////////////////////////////////////////////////////////


            //            Task 6 - Safe Division Calculator
            //Ask the user to enter two numbers and divide the first by the second, using try-catch to handle any errors safely.
            //Requirements:
            //• Wrap the input conversion and division inside a try block.
            //• Catch a DivideByZeroException and print a friendly message if the second number is zero.
            //• Catch a general Exception(or FormatException) and print a friendly message if the input is not a valid number.
            //• Print the division result only when no error occurs.


            try
            {
                Console.Write("\nEnter the first number: ");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                int result = firstNumber / secondNumber;

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers only.");
            }

            ///////////////////////////////////////////////////////////////////

            //            Task 7 - Repeating Menu with Exit Option
            //Build a menu - driven program using a while loop.The menu has three options: 1) Say Hello, 2) Show Current
            //Time - of - day Greeting(just print a fixed message), 3) Exit.Keep showing the menu and asking for a choice until the
            //user selects Exit.
            //Requirements:
            //• Use a while loop that keeps running until the exit option is chosen.
            //• Use a switch-case statement inside the loop to handle the three options.
            //• Use try-catch around reading the menu choice, in case the user enters a non - numeric value; print an error
            //message and show the menu again instead of crashing.
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("This is our menu:");
                Console.WriteLine("1. Say hello");
                Console.WriteLine("2. Show current time");
                Console.WriteLine("3. Exit");
                Console.Write("Choose your option number: ");


                try
                {

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello");
                            break;
                        case 2:
                            Console.WriteLine("It is 10:00 AM, Good Morning");
                            break;

                        case 3:
                            Console.WriteLine("Good bye");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("invalid option, please chose 1,2 or 3");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number");
                }
            }
        }
    }
}

///////////////////////////////////////////////////////////////////


