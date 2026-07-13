namespace Task6_Solution
{
    internal class Program
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
        static void Main(string[] args)
        {
            
        }
    }
}
