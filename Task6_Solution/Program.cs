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

        //Task 16 - Quick Account Opening
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
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

        //Case 17 - Total Students Counter
        private static int StudentCount = 0;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Registration email sent.");
        }
        public static int GetStudentCount()
        {
            return StudentCount;
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
        static BankAccount acc1 = new BankAccount( 1163, "karim",  120 );
        static BankAccount acc2 = new BankAccount( 15203, "Ali",  63 );

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
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Open Account");
                Console.WriteLine("17. Total Students Counter");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Case1_ViewAccount(); break;
                    case "2": Case2_UpdateAddress(); break;
                    case "3": Case3_Deposit(); break;
                    case "4": Case4_Withdraw(); break;
                    case "5": Case5_ViewProduct(); break;
                    case "6": Case6_RegisterStudent(); break;
                    case "7": Case7_CompareBalances(); break;
                    case "8": Case8_Restock(); break;
                    case "9": Case9_Transfer(); break;
                    case "10": Case10_UpdateGrade(); break;
                    case "11": Case11_ReportCard(); break;
                    case "12": Case12_AccountHealth(); break;
                    case "13": Case13_BulkSale(); break;
                    case "14": Case14_Scholarship(); break;
                    case "15": Case15_TopUp(); break;
                    case "16": Case16_QuickOpen();break;
                    case "17": Case17_StudentCount(); break;
                    case "18":
                    case "19":
                    case "20": running = false; Console.WriteLine("Goodbye!"); break;
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

                //Case 5 - View Product Details
                static void Case5_ViewProduct()
                {
                    Product p = PickProduct();
                    double value = p.GetInventoryValue();
                    Console.WriteLine($"Total inventory value: {value}");
                }

                //Case 6 - Register a Student
                static void Case6_RegisterStudent()
                {
                    Student s = PickStudent();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    s.Register(email);
                    Console.WriteLine($"{s.Name} has been registered successfully.");
                }

                //Case 7 - Compare Two Account Balances
                static void Case7_CompareBalances()
                {
                    if (acc1.Balance > acc2.Balance)
                        Console.WriteLine($"{acc1.HolderName} has more money.");
                    else if (acc2.Balance > acc1.Balance)
                        Console.WriteLine($"{acc2.HolderName} has more money.");
                    else
                        Console.WriteLine("Both accounts have equal balances.");
                }


                //Case 8 - Restock Product & Stock Level Check
                static void Case8_Restock()
                {
                    Product p = PickProduct();
                    Console.Write("Enter quantity to restock: ");
                    int qty = int.Parse(Console.ReadLine());
                    p.Restock(qty);

                    if (p.StockQuantity < 10)
                        Console.WriteLine("Stock level: Low");
                    else if (p.StockQuantity <= 49)
                        Console.WriteLine("Stock level: Moderate");
                    else
                        Console.WriteLine("Stock level: Well Stocked");
                }

                //Case 9 - Transfer Between Accounts
                static void Case9_Transfer()
                {
                    Console.WriteLine("-- Choose SOURCE account --");
                    BankAccount from = PickAccount();
                    Console.WriteLine("-- Choose DESTINATION account --");
                    BankAccount to = PickAccount();
                    Console.Write("Enter amount to transfer: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (from.Balance >= amount)
                    {
                        from.Withdraw(amount);
                        to.Deposit(amount);
                        Console.WriteLine("Transfer successful.");
                    }
                    else
                    {
                        Console.WriteLine("Transfer failed: insufficient funds in source account.");
                    }
                }

                //Case 10 - Update Student Grade (Validated)
                static void Case10_UpdateGrade()
                {
                    Student s = PickStudent();
                    Console.Write("Enter new grade: ");
                    string input = Console.ReadLine();

                    int newGrade;
                    bool isNumber = int.TryParse(input, out newGrade);

                    if (!isNumber)
                    {
                        Console.WriteLine("Invalid input: not a number. No change made.");
                        return;
                    }
                    if (newGrade < 0 || newGrade > 100)
                    {
                        Console.WriteLine("Invalid grade: must be between 0 and 100. No change made.");
                        return;
                    }
                    s.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                }

                //Case 11 - Student Report Card
                static void Case11_ReportCard()
                {
                    Student s = PickStudent();
                    string result = s.Grade >= 60 ? "Pass" : "Fail";
                    Console.WriteLine("---- Report Card ----");
                    Console.WriteLine($"Name: {s.Name}");
                    Console.WriteLine($"Address: {s.Address}");
                    Console.WriteLine($"Grade: {s.Grade}");
                    Console.WriteLine($"Result: {result}");
                }
                //Case 12 - Case 12 - Account Health Status
                static void Case12_AccountHealth()
                {
                    BankAccount acc = PickAccount();
                    string status;
                    if (acc.Balance < 50) status = "Low Balance";
                    else if (acc.Balance <= 1000) status = "Healthy";
                    else status = "Premium";
                    Console.WriteLine($"Account status: {status}");
                }
                // Case 13 - Bulk sale With Revenue Calculation

                static void Case13_BulkSale()
                {
                    Product p = PickProduct();
                    Console.Write("Enter quantity to sell: ");
                    int qty = int.Parse(Console.ReadLine());

                    if (qty > p.StockQuantity)
                    {
                        int needed = qty - p.StockQuantity;
                        Console.WriteLine($"Not enough stock. You need {needed} more unit(s). Sale cancelled.");
                    }
                    else
                    {
                        p.Sell(qty);
                        double revenue = qty * p.Price;
                        Console.WriteLine($"Sale complete. Revenue: {revenue}");
                    }
                }
                //Task 14 - Scholarship Eligibility Check
                static void Case14_Scholarship()
                {
                    Console.WriteLine("-- Choose the student --");
                    Student s = PickStudent();
                    Console.WriteLine("-- Choose the account to check --");
                    BankAccount acc = PickAccount();

                    bool gradeOk = s.Grade >= 80;
                    bool balanceOk = acc.Balance >= 100;

                    if (gradeOk && balanceOk)
                    {
                        Console.WriteLine("Eligible");
                    }
                    else
                    {
                        Console.WriteLine("Not Eligible because:");
                        if (!gradeOk) Console.WriteLine("- Grade is below 80");
                        if (!balanceOk) Console.WriteLine("- Balance is below 100");
                    }
                }

                //Case 15 - Full Balance Top-Up Flow

                static void Case15_TopUp()
                {
                    BankAccount acc = PickAccount();
                    double before = acc.Balance;

                    if (before < 50)
                    {
                        double topUp = 100 - before;
                        acc.Deposit(topUp);
                        Console.WriteLine($"Balance before: {before}");
                        Console.WriteLine($"Balance after: {acc.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("No top-up needed.");
                    }

                }

                //Task 16 - Quick Account Opening

                static void Case16_QuickOpen()
                {
                    Console.Write("Enter new account number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Enter holder name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter starting balance: ");
                    double balance = double.Parse(Console.ReadLine());

                    BankAccount extraAccount = new BankAccount(number, name, balance);

                    Console.WriteLine("New account created:");
                    Console.WriteLine($"Number: {extraAccount.AccountNumber}, Holder: {extraAccount.HolderName}, Balance: {extraAccount.Balance}");
                }

                //Case 17 - Total Students Counter

                static void Case17_StudentCount()
                {
                    int total = Student.GetStudentCount();
                    Console.WriteLine($"Total students created so far: {total}");
                }















            }
        }
    }
}
