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
            



        }
    }
}
