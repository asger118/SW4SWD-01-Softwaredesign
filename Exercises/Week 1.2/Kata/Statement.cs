using System;

namespace Kata;

public class Statement
{
    public DateTime Date { get; protected set; }
    public double TransferAmount { get; protected set; }
    public double BalanceBefore { get; protected set; }
    public double BalanceAfter { get; protected set; }
    public string? StatementType { get; protected set; }
}
