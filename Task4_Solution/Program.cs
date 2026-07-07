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

        //Task 2 - Square Number Function
        static int Square(int number)
        {
            return number * number;
        }

        //Task 3 - Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

  

        //Main 
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

            //Task 3 - Celsius to Fahrenheit Function

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);


 


        }
    }
}
