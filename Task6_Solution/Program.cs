namespace Task6_Solution
{

    //bankaccount class
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine($"Account Holder: {HolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }


    //Create Student class 
    class Student
    {
        public int Grade;
        public string Name;
        public string Address;

        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Registration email sent.");
        }
    }


    //Create Product Class 
    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Product: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock: {StockQuantity}");
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }

    internal class Program
    {
        // 6 objects 
        static BankAccount acc1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
        static BankAccount acc2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student stu1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student stu2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

        static Product prod1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product prod2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register a Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product & Stock Level Check");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Case1_ViewAccount(); break;
                    case "2": Case2_UpdateAddress();  break;
                    case "3": Case3_Deposit();  break;
                    case "4": Case4_Withdraw();  break;
                    case "5":  break;
                    case "6":  break;
                    case "7":  break;
                    case "8":  break;
                    case "9": running = false; Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
                Console.WriteLine();



                // ---------- Helpers to pick which object the user means ----------
                static BankAccount PickAccount()
                {
                    Console.Write("Pick account (1 = " + acc1.HolderName + ", 2 = " + acc2.HolderName + "): ");
                    string input = Console.ReadLine();
                    return input == "2" ? acc2 : acc1;
                }


                static Student PickStudent()
                {
                    Console.Write("Pick student (1 = " + stu1.Name + ", 2 = " + stu2.Name + "): ");
                    string input = Console.ReadLine();
                    return input == "2" ? stu2 : stu1;
                }


                static Product PickProduct()
                {
                    Console.Write("Pick product (1 = " + prod1.ProductName + ", 2 = " + prod2.ProductName + "): ");
                    string input = Console.ReadLine();
                    return input == "2" ? prod2 : prod1;
                }

                // Case 1- Viw Account Details
                static void Case1_ViewAccount()
                {
                    BankAccount acc = PickAccount();
                    acc.CheckBalance();
                }
                //Case 2 - Update Student Address
                static void Case2_UpdateAddress()
                {
                    Student s = PickStudent();
                    Console.Write("Enter new address: ");
                    s.Address = Console.ReadLine();
                    Console.WriteLine($"Address updated to: {s.Address}");
                }
                //Case 3 - Make a Deposit
                static void Case3_Deposit()
                {
                    BankAccount acc = PickAccount();
                    Console.Write("Enter deposit amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    acc.Deposit(amount);
                    Console.WriteLine($"{acc.HolderName}'s new balance: {acc.Balance}");
                }

                //Case 4 - Make a Withdrawal
                static void Case4_Withdraw()
                {
                    BankAccount acc = PickAccount();
                    Console.Write("Enter withdrawal amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    acc.Withdraw(amount);
                    Console.WriteLine($"Updated balance: {acc.Balance}");
                }
            }
        } 
    }
 }
