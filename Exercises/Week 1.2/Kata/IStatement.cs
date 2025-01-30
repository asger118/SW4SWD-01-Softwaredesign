using System;

namespace Kata;

public class IStatement
{
    protected DateTime _date;
    protected double _transferAmount;
    protected double _before;
    protected double _after;
    protected string? _statementType;
}
