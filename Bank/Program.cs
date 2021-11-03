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
            public string Login()
            {
                string username;
                string password;
                Account login = new Account();
                Console.WriteLine("please enter your username");
                username = Console.ReadLine();
                Console.WriteLine("please enter your password");
                password = Console.ReadLine();
                Console.WriteLine($"welcome {username}");
                login.ChooseTransaction();
                return username;
            }

            public string ChooseTransaction()
            {
                string balance;
                double newBalance;
                Account transact = new Account();
                Console.WriteLine("Your current balance is $594.00");
                Console.WriteLine("For Deposit press d. For withdrawal press w");
                balance = Console.ReadLine();


                if (balance == "d")
                {
                    newBalance = transact.Deposit();
                    Console.WriteLine($"Your new balance is {newBalance}");
                }
                if (balance == "w")
                {
                    newBalance = transact.Withdrawal();
                    Console.WriteLine($"your new balance is {newBalance}");
                }
                return balance;
            }

            public double Deposit()
            {
                double newBalance;
                double deposit;
                Console.WriteLine("how much do you want to deposit");
                deposit = Double.Parse(Console.ReadLine());
                newBalance = balance + deposit;
                return newBalance;
            }
            public double Withdrawal()
            {
                double newBalance;
                double withdrawal;
                Account insufficientFunds = new Account();
                Console.WriteLine("how much do you want to withdraw");
                withdrawal = Double.Parse(Console.ReadLine());
                newBalance = balance - withdrawal;

                if (withdrawal > balance)
                {
                    Console.WriteLine("you do no have sufficient balance to complete this transaction");
                    insufficientFunds.CompleteTransaction();
                    newBalance = balance;
                } 
                return newBalance;


            }

            public void CompleteTransaction()
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
                    start.Login();
                    start.ChooseTransaction();
                    start.CompleteTransaction();
                }
            }
        } 
        static void Main(string[] args)
        {  
            Account bank = new Account();

            bank.Login();
            bank.ChooseTransaction();
            bank.CompleteTransaction();
            Console.ReadLine();
        }
    }

    
}
