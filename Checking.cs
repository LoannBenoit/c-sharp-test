namespace BankAccount {
    public class Checking : Account
    {
        public double balance;
        public string accountType;
        public IList<string> depositTransactions = new List<string>();
        public IList<string> withdrawTransactions = new List<string>();
        public Checking(double balance) {
            this.balance = balance;
            accountType = "Checking Account";
        }

        public void DisplayCheckingBalance() {
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
            string transaction = $"Transaction : +${amount.ToString()} at {depositeDate.ToString()}. Current balance : ${this.balance.ToString()}";
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
            string transaction = $"Transaction : -${amount.ToString()} at {withdrawDate.ToString()}. Current balance : ${this.balance.ToString()}";
            Console.WriteLine(transaction);
            withdrawTransactions.Add(transaction);
            Console.WriteLine("Hit Enter to Display Banking Menu");
        }
    }
}