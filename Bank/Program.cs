using System;

namespace Bank
{
    class Program
    {
        public class Account
        {
            public double balance;
            public Account()
            {
                balance = 594.00;
            }
            public string login()
            {
                string username;
                string password;
                Console.WriteLine("please enter your username");
                username = Console.ReadLine();
                Console.WriteLine("please enter your password");
                password = Console.ReadLine();
                Console.WriteLine($"welcome {username}");
                return username;
            }

            public string chooseTransaction()
            {
                string balance;
                double newBalance;
                Account transact = new Account();
                Console.WriteLine("Your current balance is $594.00");
                Console.WriteLine("For Deposit press d. For withdrawal press w");
                balance = Console.ReadLine();


                if (balance == "d")
                {
                    newBalance = transact.deposit();
                    Console.WriteLine($"Your new balance is {newBalance}");
                }
                if (balance == "w")
                {
                    newBalance = transact.withdrawal();
                    Console.WriteLine($"your new balance is {newBalance}");
                }
                return "";
            }

            public double deposit()
            {
                double newBalance;
                double deposit;
                Console.WriteLine("how much do you want to deposit");
                deposit = Double.Parse(Console.ReadLine());
                newBalance = balance + deposit;
                return newBalance;
            }
            public double withdrawal()
            {
                double newBalance;
                double withdrawal;
                Console.WriteLine("how much do you want to withdraw");
                withdrawal = Double.Parse(Console.ReadLine());
                newBalance = balance - withdrawal;
                return newBalance;
            }

            public string completeTransaction()
            {
                Console.WriteLine("enter yes if you want to make transaction or enter no to terminate");
                string completed;
                completed = Console.ReadLine();

                if (completed == "no")
                {
                    Console.WriteLine("thanks for banking with us");
                }
                if (completed == "yes")
                {
                    Account start = new Account();
                    start.login();
                    start.chooseTransaction();
                    start.completeTransaction();
                }
                return completed;
            }
        } 
        static void Main(string[] args)
        {  
            Account bank = new Account();

            bank.login();
            bank.chooseTransaction();
            bank.completeTransaction();
            Console.ReadLine();
        }
    }

    
}
