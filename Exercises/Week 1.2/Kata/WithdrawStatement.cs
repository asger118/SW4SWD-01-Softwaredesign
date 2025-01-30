using System;

namespace Kata;

public class WithdrawStatement : IStatement
{
    public WithdrawStatement(double transferAmount, double before, double after)
    {
        Date = DateTime.Now;
        TransferAmount = transferAmount;
        BalanceBefore = before;
        BalanceAfter = after;
        StatementType = "Withdraw";
    }
}
