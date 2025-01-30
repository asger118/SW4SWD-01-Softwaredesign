using Kata;
class Program
{
    static void Main(string[] args)
    {
        var account = new Account(1000);
        var account2 = new Account(0);
        account.Deposit(500);
        account.Withdraw(200);
        account.Transfer(300, account2);
        account.PrintAllStatements();

        account2.PrintAllStatements();
    }
}