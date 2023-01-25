// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace BankAccount {
    public class Program {
        static void Main(string[] args) {
            bool programOn = true;
            Account account = new Account();
            Checking checking = new Checking(2000);
            Savings savings = new Savings(10000);
            IList<string> checkingTransactions = new List<string>();
            IList<string> savingsTransactions = new List<string>();
            Console.WriteLine("Hello, hit Enter to Display Banking Menu");
            do {
                switch (Console.ReadLine().ToUpper()) {

                    case "I":
                        account.DisplayInformations();
                        break;

                    case "CB":
                        checking.DisplayCheckingBalance();
                        break;
                    
                    case "SB":
                        savings.DisplaySavingsBalance();
                        break;

                    case "CD":
                        checking.Deposit();
                        break;

                    case "SD":
                        savings.Deposit();
                        break;

                    case "CW":
                        checking.Withdraw();
                        break;

                    case "SW":
                        savings.Withdraw();
                        break;

                    case "X" :
                    foreach (string deposit in checking.depositTransactions)
                    {
                        checkingTransactions.Add(deposit);
                    }

                    foreach (string deposit in savings.depositTransactions)
                    {
                        savingsTransactions.Add(deposit);
                    }

                    foreach (string withdraw in checking.withdrawTransactions)
                    {
                        checkingTransactions.Add(withdraw);
                    }

                    foreach (string withdraw in savings.withdrawTransactions)
                    {
                        savingsTransactions.Add(withdraw);
                    }

                    account.saveTransaction("Checking.txt", checkingTransactions);
                    account.saveTransaction("Savings.txt", savingsTransactions);
                    Console.WriteLine("Thanks and come again !");
                    programOn = false;
                    Environment.Exit(1);
                        break;

                    default:
                        account.DisplayMenu();
                        break;
                }
            } while (programOn);
            
        }
    }
}