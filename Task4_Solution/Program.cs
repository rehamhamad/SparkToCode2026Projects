using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4_Solution
{
    internal class Program
    {

        //Task 1 - Personalized Welcome Function
        //Write a function called PrintWelcome that takes the user's name (string) as a parameter and does not return a
        //value.Inside the function, print a personalized welcome message.Ask the user for their name in Main, then call the
        //function.
        //Requirements:
        //• The function must have a void return type and exactly one string parameter.
        //• All console output for the welcome message must happen inside the function, not in Main.

        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "! We are glad to have you here.");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
        }



        ////////////////////////////////////////////////////////////////////
        



    }
}
