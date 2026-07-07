using System.Drawing;
using System.Reflection.Metadata;
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

        //Task 4 - Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }


        //Task 5 - Even or Odd Function
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }


        //Task 6 - Rectangle Area & Perimeter Functions

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
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

            //Task 4 - Fixed Menu Display Function

            DisplayMenu();


            //Task 5 - Even or Odd Function

            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            bool Result = IsEven(number1);

            if (Result)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            //Task 6 - Rectangle Area & Perimeter Functions
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

        }
    }
}
