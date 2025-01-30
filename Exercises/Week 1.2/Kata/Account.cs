namespace Kata;

public class Account
{
    public enum FilterType
    {
        All,
        Deposit,
        Withdraw,
        Date
    }
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

    public void PrintStatementsByFilter(FilterType filter, DateTime? date = null)
    {
        IEnumerable<Statement> filteredStatements;

        switch (filter)
        {
            case FilterType.All:
                filteredStatements = _statements;
                break;
            case FilterType.Deposit:
            case FilterType.Withdraw:
                filteredStatements = _statements.Where(s => s.StatementType.Equals(filter.ToString(), StringComparison.OrdinalIgnoreCase));
                break;
            case FilterType.Date:
                if (date == null)
                {
                    throw new ArgumentException("Date must be provided for Date filter");
                }
                filteredStatements = _statements.Where(s => s.Date.Date == date.Value.Date);
                break;
            default:
                throw new ArgumentException("Invalid filter type");
        }

        PrintStatements(filteredStatements, filter);
    }

    private void PrintStatements(IEnumerable<Statement> statements, FilterType filter)
    {
        Console.WriteLine($"\n\u001b[1m{filter.ToString()} statements for account ID: {Id}\u001b[0m");
        Console.WriteLine("\u001b[1m{0,-15} | {1,-10} | {2,-15} | {3,-15} | {4,-20}\u001b[0m", "Statement Type", "Amount", "Balance Before", "Balance After", "Date");
        Console.WriteLine(new string('-', 80));
        foreach (var statement in statements)
        {
            Console.WriteLine("{0,-15} | {1,-10} | {2,-15} | {3,-15} | {4,-20}", statement.StatementType, statement.TransferAmount, statement.BalanceBefore, statement.BalanceAfter, statement.Date);
        }
    }
}

