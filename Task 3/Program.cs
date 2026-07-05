using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            ////////////////////////////////////////////////////////////

            //            Task 3 - Name Formatter
            //Ask the user to enter their full name, then print it in uppercase, in lowercase, and print how many characters it
            //contains.
            //Requirements:
            //• Use.ToUpper() and.ToLower() on the entered name.
            //• Use.Length to count the characters.
            //• Print all three results with clear labels.

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();
            string upperCaseName = fullName.ToUpper();
            string lowerCaseName = fullName.ToLower();
            int characterCount = fullName.Length;
            Console.WriteLine("Uppercase: " + upperCaseName);
            Console.WriteLine("Lowercase: " + lowerCaseName);
            Console.WriteLine("Number of Characters: " + characterCount);

            ////////////////////////////////////////////////////////////

            //            Task 4 - Subscription End Date
            //Ask the user to enter the number of days of a free trial, then calculate and print the date on which the trial ends,
            //starting from today.
            //Requirements:
            //• Use DateTime.Today as the starting point.
            //• Use.AddDays to calculate the end date.
            //• Print the end date using .ToString("yyyy-MM-dd").

            Console.Write("Enter the number of free trial days: ");
            int trialDays = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(trialDays);
            Console.WriteLine("Trial End Date: " + endDate.ToString("yyyy-MM-dd"));

            ////////////////////////////////////////////////////////////

            //            Task 5 - Grade Rounding System
            //Ask the user to enter their raw exam score as a decimal number(e.g. 74.6), round it to the nearest whole number,
            //then decide if they passed.
            //Requirements:
            //• Use Math.Round to round the score to zero decimal places.
            //• A rounded score of 60 or above is a Pass, anything below is a Fail - use if-else.
            //• Print both the rounded score and the pass/ fail result

            Console.Write("Enter your exam score: ");
            double score = double.Parse(Console.ReadLine());
            double roundedScore = Math.Round(score, 0);
            if (roundedScore >= 60)
            {
                Console.WriteLine("Rounded Score: " + roundedScore);
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Rounded Score: " + roundedScore);
                Console.WriteLine("Result: Fail");

            }

            ////////////////////////////////////////////////////////////

            //            Task 6 - Password Strength Checker
            //Ask the user to enter a password, then check whether it meets two basic conditions: it must be at least 8 characters
            //long, and it must not contain the word "password" in it.
            //Requirements:
            //• Use.Length to check the minimum length requirement.
            //• Use.Contains(with a case -insensitive comparison, e.g.after.ToLower()) to check for the forbidden word.
            //• Combine both checks using logical operators and print "Strong" or "Weak" with the reason.

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            bool isLongEnough = password.Length >= 8;
            bool containsForbiddenWord = password.ToLower().Contains("password");

            if (isLongEnough && !containsForbiddenWord)
            {
                Console.WriteLine("Strong: Meets length requirement and does not contain the word 'password'.");
            }
            else
            {
                Console.WriteLine("Weak:");

                if (!isLongEnough)
                {
                    Console.WriteLine("- Password must be at least 8 characters long.");
                }

                if (containsForbiddenWord)
                {
                    Console.WriteLine("- Password must not contain the word 'password'.");
                }
            }















        }
    }
}