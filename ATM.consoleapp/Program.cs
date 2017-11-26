using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.consoleapp
{
    class Program
    {

        public class Account
        {
            private double balance;

            public Account()
            {
                balance = 500.00;
            }

            public double deposit()
            {
                double NewBalance;
                double deposit;
                Console.WriteLine("Please enter amount to deposit");
                deposit = Double.Parse(Console.ReadLine());
                NewBalance = balance + deposit;

                return NewBalance;
            }

            public double withdrawl()
            {
                double NewBalance;
                double withdrawl;
                Console.WriteLine("Please enter amount to withdrawal");
                withdrawl = double.Parse(Console.ReadLine());
                NewBalance = balance - withdrawl;

                return NewBalance;
            }
        }
        static void Main(string[] args)
        {
            double NewBalance;
            string balance;
            Account bank = new Account();

            Console.WriteLine("Current Balance is 500.00");
            Console.WriteLine("Press d for deposit or press w for withdrawl");

            balance = Console.ReadLine();

            if (balance == "d")
            {
                NewBalance = bank.deposit();
                Console.Write($"Your new balance is", NewBalance );
            }
            if(balance == "w")
            {
                NewBalance = bank.withdrawl();
                Console.WriteLine("Your new balance is", NewBalance);
            }

            Console.ReadLine();
        }
    }
}
