namespace Kata;

public class Account
{
    static int _idCounter = 0;
    public double Balance { get; private set; }
    public int Id { get; private set; }
    private readonly List<Statement> _statements = new List<Statement>();

    public Account(double balance)
    {
        Balance = balance;
        Id = ++_idCounter;
    }

    public double Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount must be positive");
        }
        else if (Balance < amount)
        {
            throw new ArgumentException("Insufficient funds");
        }
        else if (amount == 0)
        {
            throw new ArgumentException("Amount must be greater than zero");
        }
        _statements.Add(new WithdrawStatement(amount, Balance, Balance - amount));

        Balance -= amount;

        return amount;
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount must be positive");
        }
        else if (amount == 0)
        {
            throw new ArgumentException("Amount must be greater than zero");
        }
        _statements.Add(new DepositStatement(amount, Balance, Balance + amount));

        Balance += amount;
    }

    public void Transfer(double amount, Account targetAccount)
    {
        if (targetAccount == null)
        {
            throw new ArgumentNullException(nameof(targetAccount));
        }

        targetAccount.Deposit(Withdraw(amount));
    }

    public void PrintAllStatements()
    {
        Console.WriteLine($"\n\u001b[1mStatements for account ID: {Id}\u001b[0m");
        Console.WriteLine("\u001b[1m{0,-15} | {1,-10} | {2,-15} | {3,-15} | {4,-20}\u001b[0m", "Statement Type", "Amount", "Balance Before", "Balance After", "Date");
        foreach (var statement in _statements)
        {
            Console.WriteLine("{0,-15} | {1,-10} | {2,-15} | {3,-15} | {4,-20}", statement.StatementType, statement.TransferAmount, statement.BalanceBefore, statement.BalanceAfter, statement.Date);
        }
    }
}

