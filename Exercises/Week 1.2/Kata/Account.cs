namespace Kata;

public class Account
{
    public double Balance { get; private set; }
    private List<IStatement> _statements = new List<IStatement>();

    public Account(double balance)
    {
        Balance = balance;
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
}

