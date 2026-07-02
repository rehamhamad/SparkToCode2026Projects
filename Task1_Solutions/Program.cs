using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Personal Info Card 

            //Declare variables to store a person's name (string), age (int), height in meters (double), and whether they are a
            //student(bool).Assign them values directly in the code(no input needed), then print them as a single formatted info
            //card.
            //Requirements:
            //• Use at least four variables with four different data types.
            //• Print each value on its own line with a clear label.
            //Sample output: Name: Sara, Age: 21, Height: 1.65, Student: True

            Console.WriteLine("Task 1 : Personal Info Card\n");
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

            Console.WriteLine("Task 2 : Reactangle Calculator\n");
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

            Console.WriteLine("\nTask 3 - Even or Odd Checker\n");
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

            Console.WriteLine("Task 4 - Voting Eligibility\n");
            Console.Write("Enter Your Age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Do you have a valid national ID? (yes/no): ");
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

            Console.WriteLine("\nTask 5 - Grade Letter Lookup\n");
            Console.Write("Enter Your Grade (A, B, C, D, or F): ");
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

            Console.WriteLine("\nTask 6 - Temperature Converter\n");
            Console.Write("Enter the temperature in Celsius: ");
            float Ctemp = float.Parse(Console.ReadLine());

            float Ftemp = (Ctemp * 9 / 5) + 32;
            if (Ctemp < 10)
            {
                Console.WriteLine("The Temperature in Fehrenhite is: " + Ftemp + " The weather is Cold");
            }
            else if (Ctemp >= 10 && Ctemp <= 30)
            {
                Console.WriteLine("The Temperature in Fehrenhite is: " + Ftemp + " The weather is Mild");
            }
            else
            {
                Console.WriteLine("The Temperature in Fehrenhite is: " + Ftemp + " The weather is Hot");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 7 - Movie Ticket Pricing

            //Ask the user to enter their age and calculate the ticket price based on the following age groups: 0 - 12, 13 - 59, and 60
            //and above.
            //Requirements:
            //• Children(0 - 12): 2.000 OMR, Adults(13 - 59): 5.000 OMR, Seniors(60 +): 3.000 OMR.
            //• Use if / else if / else to determine the correct category.
            //• Print the category name along with the final price

            Console.WriteLine("\nTask 7 - Movie Ticket Pricing\n ");
            Console.Write("Enter Your Age: ");
            int AGE = int.Parse(Console.ReadLine());

            if (AGE >= 0 && AGE <= 12)
            {
                Console.WriteLine("Category: Chiled (0 - 12 ), Price; 2.000 OMRT");
            }
            else if (AGE >= 13 && AGE <= 59)
            {
                Console.WriteLine("Category: Adults ( 13 - 59 ), Price: 5.000 OMR");
            }
            else
            {
                Console.WriteLine("Category: Seniors ( 60 + ), Price: 3.000 OMR");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 8 - Restaurant Bill with Membership Discount
            //Ask the user to enter their total bill amount and whether they are a loyalty member(yes/ no). Apply a discount only
            //when both conditions below are satisfied.
            //Requirements:
            //• A 15 % discount applies only if the bill is greater than 20 OMR AND the customer is a member.
            //• Use the logical AND operator (&&) to combine both conditions in one if statement.
            //• Print the original bill, the discount amount(if any), and the final amount to pay.

            Console.WriteLine("\nTask 8 - Restaurant Bill with Membership Discount\n");
            Console.Write("Enter Your Total Bill Amount: ");
            float bill = float.Parse(Console.ReadLine());
            Console.Write("Do you have a loyalty member? (yes / no) ");
            string member = Console.ReadLine().ToLower();

            double dis15 = 0.15 * bill;
            double discount = bill - dis15;

            bool val;
            if (member == "yes" && bill > 20)
            {
                val = true;
                Console.WriteLine("Original Bill: " + bill + " OMR");
                Console.WriteLine("Discount Amount: " + dis15 + " OMR");
                Console.WriteLine("Bill after 15% discount: " + discount + " OMR");

            }
            else
            {
                val = false;
                Console.WriteLine("There is no Discount applied");
                Console.WriteLine("Original Bill: " + bill + " OMR");
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 9 - Day Name Finder
            //Ask the user to enter a number from 1 to 7 representing a day of the week, then print the full day name using a
            //switch-case statement.
            //Requirements:
            //• 1 → Sunday, 2 → Monday, ... 7 → Saturday(define the full mapping yourself).
            //• Print "Invalid day number" for any value outside 1 - 7 using the default case.

            Console.WriteLine("Task 9 - Day Name Finder");
            Console.Write("Enter a number from 1 to 7 representing a day of the week: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 10 - Mini Calculator

            //Ask the user to enter two numbers and an operator character(+, -, *, /, or %).Perform the matching operation and
            //print the result using a switch-case statement on the operator.
            //Requirements:
            //• Support the five operators: +, -, *, /, %.
            //• Before performing division or modulus, check with an if statement that the second number is not zero; if it is zero,
            //print "Cannot divide by zero" instead of performing the operation.
            //• Print "Invalid operator" for any other character using the default case.

            Console.WriteLine("\nTask 10 - Mini Calculator\n");
            Console.Write("Enter your first number:");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter your second number:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter two numbers and an operator (+, -, *, /, or %): ");
            string ope = Console.ReadLine();
            float addition = num1 + num2;
            float subtraction = num1 - num2;
            float multiplication = num1 * num2;
            float division = num1 / num2;
            float reminder = num1 % num2;

            switch (ope)
            {
                case "+":
                    Console.Write(addition);
                    break;
                case "-":
                    Console.Write(subtraction);
                    break;
                case "*":
                    Console.Write(multiplication);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.Write(division);
                    }
                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.Write(reminder);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 11 - Loan Eligibility System

            //A bank wants a quick eligibility check for a personal loan.Ask the user to enter their age, monthly income, and
            //whether they have an existing loan(yes / no).Decide whether they are eligible.
            //Requirements:
            //• Eligible if: age is between 21 and 60(inclusive) AND monthly income is at least 400 OMR AND the applicant does
            //NOT have an existing loan.
            //• Combine the three conditions using && and! inside a single if-else statement.
            //• If not eligible, print the specific reason(age out of range, income too low, or has an existing loan). Decide for
            //yourself how to structure the conditions to report the correct reason


            // Task 11 - Loan Eligibility System

            Console.Write("\nEnter your age: \n");
            int UserAge = int.Parse(Console.ReadLine());

            Console.Write("Enter your monthly income (OMR): ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Do you have an existing loan? (yes/no): ");
            string existingLoan = Console.ReadLine().ToLower();

            bool hasLoan = existingLoan == "yes";

            if (UserAge >= 21 && UserAge <= 60 && income >= 400 && !hasLoan)
            {
                Console.WriteLine("You are eligible for the loan.");
            }
            else
            {
                if (UserAge < 21 || UserAge > 60)
                {
                    Console.WriteLine("Not eligible: Age is out of range.");
                }

                if (income < 400)
                {
                    Console.WriteLine("Not eligible: Income is too low.");
                }

                if (hasLoan)
                {
                    Console.WriteLine("Not eligible: You have an existing loan.");
                }
            }




        }
    }
}
