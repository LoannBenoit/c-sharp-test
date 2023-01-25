using System;
using System.Collections.Generic;

namespace BankAccount {
    public class Savings 
    {
        protected double balance;
        protected string accountType;
        public IList<string> depositTransactions = new List<string>();
        public IList<string> withdrawTransactions = new List<string>();

        public Savings(double balance) : base() {
            this.balance = balance;
            accountType = "Savings Account";
        }

        public void DisplaySavingsBalance() {
            Console.WriteLine(this.accountType + " balance : $" + this.balance);
            Console.WriteLine("Hit Enter to Display Banking Menu");
        }

        public void Deposit() {
            DateTime depositeDate = DateTime.Now;
            Console.WriteLine("How much would you like to deposit ?");
            double amount = Convert.ToDouble(Console.ReadLine());
            double newBalance = this.balance + amount;
            this.balance = newBalance;
            Console.WriteLine("You deposited: $" + amount);
            string transaction = $"Transaction : +${amount.ToString()} at {depositeDate.ToString()}. Current balance : ${newBalance.ToString()}";
            Console.WriteLine(transaction);
            depositTransactions.Add(transaction);
            Console.WriteLine("Hit Enter to Display Banking Menu");
        }

        public void Withdraw() {
            DateTime withdrawDate = DateTime.Now;
            Console.WriteLine("How much would you like to withdraw ?");
            double amount = Convert.ToDouble(Console.ReadLine());
            double newBalance = this.balance - amount;
            this.balance = newBalance;
            Console.WriteLine("You withdrew : $" + amount);
            string transaction = $"Transaction : -${amount.ToString()} at {withdrawDate.ToString()}. Current balance : ${newBalance.ToString()}";
            Console.WriteLine(transaction);
            withdrawTransactions.Add(transaction);
            Console.WriteLine("Hit Enter to Display Banking Menu");
        }
    }
}