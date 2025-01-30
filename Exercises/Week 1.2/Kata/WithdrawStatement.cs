namespace Kata;

public class WithdrawStatement : Statement
{
    public WithdrawStatement(double transferAmount, double balanceBefore, double balanceAfter)
    {
        Date = DateTime.Now;
        TransferAmount = transferAmount;
        BalanceBefore = balanceBefore;
        BalanceAfter = balanceAfter;
        StatementType = "Withdraw";
    }
}
