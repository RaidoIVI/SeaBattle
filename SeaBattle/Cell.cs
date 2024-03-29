﻿


public class Cell
{
    public int X { get; }
    public int Y { get; }
    public CellStatus Value { get; set; }
    private Char _cellSymbol;


    public Cell()
    {
        X = 0;
        Y = 0;
        Value = CellStatus.Empty;
    }

    public Cell(int x, int y)
    {
        X = x;
        Y = y;
        Value = CellStatus.Empty;
    }

    public Cell(int x, int y, CellStatus value)
    {
        X = x;
        Y = y;
        Value = value;
    }

    internal void SetValue(CellStatus value)
    {
        Value = value;
    }

    public void Draft(char symbol)
    {
        Output.CPrint(X, Y, symbol);
    }

    public void Draft()
    {
        Output.CPrint(X, Y, Value);
    }

    public void Draft(int x, int y)
    {
        Output.CPrint(X + x, Y + y, Value);
    }

    public void Draft(int x, int y, char symbol)
    {
        Output.CPrint(X + x, Y + y, symbol);
    }

}
