using System.IO;

namespace BankAccount {
    public class Account {
        // Variables
        private string firstName;
        private string lastName;
        private string accountType;

        // Properties
        public string Firstname {
            get { return "Loann"; }
        }

        public string Lastname {
            get { return "Benoit"; }
        }
        public string AccountType {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        // Methods
        public void DisplayMenu() {
            Console.WriteLine(@"Please select an option below:
[I] View Account Holder Information
[CB] Checking - View Balance
[CD] Checking - Deposit Funds
[CW] Checking - Withdraw Funds
[SB] Savings - View Balance
[SD] Savings - Deposit Funds
[SW] Savings - Withdraw Funds
[X] Exit");
        }

        public void DisplayInformations() {
            Console.WriteLine("Accounnt Holder : " + this.Firstname + " " + this.Lastname);
            Console.WriteLine("Hit Enter to Display Banking Menu");
        }

        public void saveTransaction(string fileName, IList<string> transactions) {
            using (StreamWriter summary = new StreamWriter(fileName))
            {
                foreach (string transaction in transactions)
                {
                    summary.WriteLine(transaction);
                }
            }
        }
    }
}