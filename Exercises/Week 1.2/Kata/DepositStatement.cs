using System;

namespace Kata;

public class DepositStatement : Statement
{
    public DepositStatement(double transferAmount, double balanceBefore, double balanceAfter)
    {
        Date = DateTime.Now;
        TransferAmount = transferAmount;
        BalanceBefore = balanceBefore;
        BalanceAfter = balanceAfter;
        StatementType = "Deposit";
    }
}
