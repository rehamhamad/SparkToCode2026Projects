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
            
        }
    }
}
