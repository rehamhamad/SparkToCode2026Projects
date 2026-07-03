using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
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
                Console.WriteLine("\nThis is our menu:");
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
            ///////////////////////////////////////////////////////////////////

            //Task 8 - Sum of Even Numbers Only
            //Ask the user to enter a positive whole number N, then use a for loop to calculate the sum of only the even numbers
            //from 1 to N.
            //Requirements:
            //• Use the modulus operator (%) with an if statement inside the loop to check whether each number is even before
            //adding it to the total.
            //• Print the final sum after the loop finishes

            Console.WriteLine("\nEnter a positive whole number:");
            int Pnum = int.Parse(Console.ReadLine());
            int sumEven = 0;
            for ( int i = 0 ; i<=Pnum ; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
            }
            Console.WriteLine("The sum of all even numbers from 1 to " + Pnum + " is " + sumEven);


            ///////////////////////////////////////////////////////////////////

            //            Task 9 - Validated Positive Number Input
            //Build a small program that keeps asking the user to enter a positive whole number until a valid one is provided, then
            //calculates and prints the sum of all whole numbers from 1 to that number.
            //Requirements:
            //• Use a do -while loop combined with try-catch to repeatedly ask for input: catch the error and print a message if the
            //input is not a valid whole number, and keep looping in that case as well.
            //• Once a valid number is captured, use an if statement to also reject zero or negative numbers and loop again asking
            //for input.
            //• Only after a valid positive number is entered, use a separate for loop(not nested inside the input loop) to calculate
            //and print the sum from 1 to that number.


            int Pnum2 = 0;
            bool validInput = false;
            do
            {
                try
                {
                    Console.WriteLine("\nEnter A positive whole number: ");
                    Pnum2 = int.Parse(Console.ReadLine());

                    if (Pnum2 <= 0)
                    {
                        Console.WriteLine("Enter a positive number");
                    }
                    else { validInput = true; }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number");

                }
            }
            while(!validInput);
            int sumnum = 0;
            for (int i = 0; i<= Pnum2 ; i++)
            {
                sumnum += i;
            }
            Console.WriteLine("The sum of all whole numbers from 1 to " + Pnum2 + " is " + sumnum);

            ///////////////////////////////////////////////////////////////////

            //            Task 10 - Simple ATM Simulation
            //Build a simplified ATM simulation.The correct PIN is fixed in the code(for example, 1234), and the starting balance
            //is fixed at 100.000 OMR.
            //Requirements:

            //• Give the user up to 3 attempts to enter the correct PIN using a loop; wrap the PIN input in try-catch so a
            //non - numeric entry counts as a wrong attempt instead of crashing the program.If all 3 attempts fail, print "Card
            //Blocked" and stop the program.

            //• Once the PIN is correct, show a repeating menu(while loop) with four options: 1) Deposit, 2) Withdraw, 3) Check
            //Balance, 4) Exit, handled with a switch-case statement.

            //• For Deposit and Withdraw, read the amount with try-catch to handle invalid(non - numeric) input, and use an if
            //statement to reject negative amounts and, for withdrawals, amounts greater than the current balance.
            //• Update and print the balance after every successful deposit or withdrawal, and exit the loop cleanly when option 4
            //is chosen.

            int pass1 = 1234;
            int balance = 100000;
            int attempts = 0;
            bool correct = false;
            
            while (attempts < 3)
            {
                try
                {
                    Console.Write("\nEnter your PIN: ");
                    int UaserPass = int.Parse(Console.ReadLine());

                    if (UaserPass == pass1)
                    {
                        Console.WriteLine("Welcome to the ATM");
                        correct = true;

                        // ATM Menu

                        bool exitATM = false;
                        while (!exitATM)
                        {
                            Console.WriteLine("\nATM Menu:");
                            Console.WriteLine("1. Deposit");
                            Console.WriteLine("2. Withdraw");
                            Console.WriteLine("3. Check Balance");
                            Console.WriteLine("4. Exit");
                            int choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Enter the anount you want to add:");
                                    int deposit = int.Parse(Console.ReadLine());

                                    balance += deposit;

                                    Console.WriteLine("Your new balance is: " + balance);
                                    break;

                                case 2:
                                    Console.WriteLine("Enter the amount you want to withdraw:");
                                    int withdraw = int.Parse(Console.ReadLine());
                                    if (withdraw <= balance)
                                    {
                                        balance -= withdraw;
                                        Console.WriteLine("Your new balance is: " + balance);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Unsufficient funds. Your current balance is: " + balance);
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Your current balance is: " + balance);
                                    break;

                                case 4:
                                    Console.WriteLine("Returning to PIN Screen ... ");
                                    exitATM = true; // exit atm loop only
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid PIN, try again");
                        attempts++;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number");
                        attempts++;
                       
                }
            }
            if (!correct)
            {
                Console.WriteLine("Your card is blocked");
            }
        }
}
}










