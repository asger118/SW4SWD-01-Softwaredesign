namespace Kata.Tests;

public class AccountUnitTest
{
    [Theory]
    [InlineData(1000, 500)]
    [InlineData(1000, 1000)]
    [InlineData(1000, 99.99)]
    public void WithdrawTest_ValidInput(double accontBalance, double amount)
    {
        // Arrange
        var account = new Account(accontBalance);

        // Act
        account.Withdraw(amount);

        // Assert
        Assert.Equal(accontBalance - amount, account.Balance);
    }

    [Theory]
    [InlineData(1000, 0)]
    [InlineData(1000, -500)]
    [InlineData(1000, -500.99)]
    [InlineData(1000, 1500)]
    [InlineData(1000, 1500.99)]
    public void WithdrawTest_InvalidInput(double accontBalance, double amount)
    {
        // Arrange
        var account = new Account(accontBalance);

        // Act
        Action act = () => account.Withdraw(amount);

        // Assert
        Assert.Throws<ArgumentException>(act);
    }

    [Theory]
    [InlineData(1000, 500)]
    [InlineData(1000, 500.10)]
    [InlineData(1000, 999)]
    public void DepositTest_ValidInput(double accontBalance, double depositAmount)
    {
        // Arrange
        var account = new Account(accontBalance);

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.Equal(accontBalance + depositAmount, account.Balance);
    }

    [Theory]
    [InlineData(1000, -500)]
    [InlineData(1000, 0)]
    public void DepositTest_InvalidInput(double accontBalance, double depositAmount)
    {
        // Arrange
        var account = new Account(accontBalance);

        // Act
        Action act = () => account.Deposit(depositAmount);

        // Assert
        Assert.Throws<ArgumentException>(act);
    }

    [Theory]
    [InlineData(100, 100, 50)]
    [InlineData(100, 100, 100)]
    public void TransferTest_ValidInput(double accontBalance, double targetAccountBalance, double transferAmount)
    {
        // Arrange
        var account = new Account(accontBalance);
        var targetAccount = new Account(targetAccountBalance);

        // Act
        account.Transfer(transferAmount, targetAccount);

        // Assert
        Assert.Equal(accontBalance - transferAmount, account.Balance);
        Assert.Equal(targetAccountBalance + transferAmount, targetAccount.Balance);
    }

    [Theory]
    [InlineData(100, 100, -100)]
    [InlineData(100, 100, 200)]
    public void TransferTest_InvalidInput(double accontBalance, double targetAccountBalance, double transferAmount)
    {
        // Arrange
        var account = new Account(accontBalance);
        var targetAccount = new Account(targetAccountBalance);

        // Act
        Action act = () => account.Transfer(transferAmount, targetAccount);

        // Assert
        Assert.Throws<ArgumentException>(act);
    }

}
