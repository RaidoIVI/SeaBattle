
public class Cell
{
     public int X { get; private set ; }
     public int Y { get; private set ; }
     public CellStatus 
            Value { get; private set ; }


    public Cell()
    {
        X = 0;
        Y = 0;
        Value = CellStatus.Empty;
    }

    public Cell(int x, int y, CellStatus value )
    {
        X = x;
        Y = y;
        Value = value;
    }

    internal void SetValue (CellStatus value) 
    {
        Value = value;
    }

    public void Draft(char symbol) 
    {
        Output.CPrint(X, Y, symbol);    
    }

    public void Draft() 
    {
        Output.CPrint(X,Y,Value);        
    }

}
