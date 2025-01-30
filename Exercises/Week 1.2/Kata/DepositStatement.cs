using System;

namespace Kata;

public class DepositStatement : IStatement
{
    public DepositStatement(double transferAmount, double before, double after)
    {
        Date = DateTime.Now;
        TransferAmount = transferAmount;
        BalanceBefore = before;
        BalanceAfter = after;
        StatementType = "Deposit";
    }
}
