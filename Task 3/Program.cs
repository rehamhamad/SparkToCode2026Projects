using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
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

            ////////////////////////////////////////////////////////////

//            Task 7 - Clean Name Comparator
//Ask the user to enter the same name twice(once in each input), possibly typed with extra spaces or different casing,
//and check whether the two entries actually refer to the same name.
//Requirements:
//• Use.Trim() on both inputs to remove extra leading / trailing spaces.
//• Use.ToUpper()(or.ToLower()) on both inputs to ignore case differences.
//• Print "Match" or "No Match" based on the comparison.

            Console.Write("Enter the first name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the second name: ");
            string name2 = Console.ReadLine();

            string cleanName1 = name1.Trim().ToUpper();
            string cleanName2 = name2.Trim().ToUpper();

            if (cleanName1 == cleanName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }

            ////////////////////////////////////////////////////////////

//            Task 8 - Membership Expiry Checker
//Ask the user to enter their membership start date as text (e.g. "2026-01-10") and the number of valid membership
//days, then determine whether the membership is still active today.
//Requirements:
//• Use DateTime.Parse(or DateTime.TryParse inside try-catch) to convert the entered text into a DateTime value.
//• Use.AddDays on the start date to calculate the expiry date.
//• Compare the expiry date with DateTime.Today using an if-else statement and print whether the membership is
//"Active" or "Expired", along with the expiry date.


            Console.Write("Enter your membership start date (e.g. 2026-01-10): ");
            string dateInput = Console.ReadLine();

            Console.Write("Enter the number of valid membership days: ");
            string daysInput = Console.ReadLine();

            DateTime startDate;
            bool isValidDate = DateTime.TryParse(dateInput, out startDate);

            int validDays;
            bool isValidDays = int.TryParse(daysInput, out validDays);

            if (isValidDate && isValidDays)
            {
                DateTime expiryDate = startDate.AddDays(validDays);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Active - Your membership expires on " + expiryDate.ToShortDateString());
                }
                else
                {
                    Console.WriteLine("Expired - Your membership expired on " + expiryDate.ToShortDateString());
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid date and a whole number of days.");


            }

        }
    }
}