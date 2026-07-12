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
                    case 1: AddAccount(); break;
                    case 2: DepositMoney(); break;
                    case 3: WithdrawMoney(); break;
                    case 4: ShowBalance(); break;
                    case 5: TransferAmount(); break;
                    case 6: ListAllAccounts(); break;

                   //add other cases 
                }
            }
        }

        //Outside Main

        //Service 1 - Add New Account
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
            Console.WriteLine($"Opening Balance: {balance:c}");

        }

        //Service 2 - Deposit Money
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine($"Error: Account number '{accountNumber}' was not found.");
                return;
            }
            Console.Write("Enter deposit amount: ");
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid amount entered.");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
                return;
            }
            balances[index] += amount;

            Console.WriteLine($"Deposit successful. New balance for {customerNames[index]} ({accountNumber}): {balances[index]:C}");
        }

        //Service 3 - Withdraw Money
        static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNum);
            if (index == -1)
            {
                Console.WriteLine($"Error: Account number '{accNum}' was not found.");
                return;
            }
            Console.Write("Enter withdrawal amount: ");
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid amount entered.");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
                return;
            }
            if (amount > balances[index])
            {
                Console.WriteLine($"Error: Insufficient funds. Current balance is {balances[index]:C}.");
                return;
            }


            balances[index] -= amount;
            Console.WriteLine($"Withdrawal successful. New balance for {customerNames[index]} ({accNum}): {balances[index]:C}");
        }



        //Task 4 - Show Balance 
        static void ShowBalance()
        {
    
            Console.Write("Enter account number: ");
            string accNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNum);
            if (index == -1)
            {
                
                Console.WriteLine($"Error: Account number '{accNum}' was not found.");
                return;
            }

        
            Console.WriteLine("\n----- Account Details -----");
            Console.WriteLine($"Customer Name : {customerNames[index]}");
            Console.WriteLine($"Account Number: {accountNumbers[index]}");
            Console.WriteLine($"Balance       : {balances[index]:C}");
        }

        //Task 5 - Transfer Amount 
        static void TransferAmount()
        {
            Console.Write("Enter sender's account number: ");
            string senderAcc = Console.ReadLine();

            Console.Write("Enter receiver's account number: ");
            string receiverAcc = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(senderAcc);
            if (senderIndex == -1)
            {
                Console.WriteLine($"Error: Sender account '{senderAcc}' was not found.");
                return;
            }

            int receiverIndex = accountNumbers.IndexOf(receiverAcc);
            if (receiverIndex == -1)
            {
                Console.WriteLine($"Error: Receiver account '{receiverAcc}' was not found.");
                return;
            }

            Console.Write("Enter transfer amount: ");
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid amount entered.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Error: Transfer amount must be positive.");
                return;
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine($"Error: Insufficient funds in sender's account. Current balance is {balances[senderIndex]:C}.");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine("\nTransfer successful!");
            Console.WriteLine($"{customerNames[senderIndex]} ({senderAcc}) new balance : {balances[senderIndex]:C}");
            Console.WriteLine($"{customerNames[receiverIndex]} ({receiverAcc}) new balance : {balances[receiverIndex]:C}");
        }


        //Task 6 - List all account

        static void ListAllAccounts()
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("There are no accounts registered yet.");
                return;
            }

            Console.WriteLine("\n----- All Accounts -----");
            for (int i = 0; i < customerNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {customerNames[i]} | AccNumber: {accountNumbers[i]} | Balance: {balances[i]:C}");
            }
        }


















        }



}