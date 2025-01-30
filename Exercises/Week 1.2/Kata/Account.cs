namespace Kata;

public class Account
{
    public double Balance { get; private set; }

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

