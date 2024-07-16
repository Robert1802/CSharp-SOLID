namespace L_Wrong
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Using the Base Class
            Console.WriteLine("LSP - Using the Base Class");
            var account = new Account();
            account.Balance = 100;
            account.Withdraw(250);
            Console.WriteLine($"Account balance : {account.Balance}");

            // Using the derived class
            Console.WriteLine("\n\nLSP - Using the derived class");
            var account1 = new SavingsAccount();
            account1.Balance = 100;
            account1.Withdraw(250);
            Console.WriteLine($"Account balance : {account1.Balance}");
            Console.ReadLine();
        }
    }
}
