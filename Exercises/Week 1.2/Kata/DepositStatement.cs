using System;

namespace Kata;

public class DepositStatement : IStatement
{
    public DepositStatement(double transferAmount, double before, double after)
    {
        _date = DateTime.Now.Date;
        _transferAmount = transferAmount;
        _before = before;
        _after = after;
        _statementType = "Deposit";
    }
}
