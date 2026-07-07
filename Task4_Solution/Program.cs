using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4_Solution
{
    internal class Program
    {

        //Task 1 - Personalized Welcome Function
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "! We are glad to have you here.");
        }


        static int Square(int number)
        {
            return number * number;
        }

        //Task 2 - Square Number Function
        static void Main(string[] args)
        {


            //Task 1 - Personalized Welcome Function
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);

            //Task 2 - Square Number Function
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("The square is: " + result);



        }



        

    }
}
