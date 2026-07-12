using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BankingSystemApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                // Menu
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Find Richest Customer");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; 
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();   
                        break;

                   //add other cases 
                }
            }
        }

        //Outside Main
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Error: Account number already exists.");
                return;
            }

            Console.Write("Enter initial deposit: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            if (balance < 0)
            {
                Console.WriteLine("Error: Initial deposit cannot be negative.");
                return;
            }

            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(balance);

            
            Console.WriteLine("\nAccount created successfully!");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Opening Balance: {balance}");

        }


    }

}