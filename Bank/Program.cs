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
            public string login(string email, string password)
            {
                
                return "email";
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
        } 
        static void Main(string[] args)
        {
            double newBalance;
            string balance;
            string username;
            string password;
            Account bank = new Account();
            Console.WriteLine("please enter your email Address");
            username = Console.ReadLine();
            Console.WriteLine("please enter your password");
            password = Console.ReadLine();
            Console.WriteLine($"welcome {username}");
            Console.WriteLine("Your current balance is");
            Console.WriteLine("For Deposit press d. For withdrawal press w");


            balance = Console.ReadLine();

            if(balance == "d")
            {
                newBalance = bank.deposit();
                Console.WriteLine($"Your new balance is {newBalance}");
            }
            if(balance == "w")
            {
                newBalance = bank.withdrawal();
                Console.WriteLine($"your new balance is {newBalance}");
            }

            Console.WriteLine("enter yes if you want to make transaction or enter no to terminate");
            string completed;
            completed = Console.ReadLine();

            if(completed == "no")
            {
                Console.WriteLine("thanks for banking with us");
            }
            if(completed == "yes")
            {
                Console.WriteLine("ok");  
            }

            Console.ReadLine();
        }
    }

    
}
