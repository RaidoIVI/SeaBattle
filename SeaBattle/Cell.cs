
public class Cell
{
     public int X     { get; private set ; }
     public int Y     { get; private set ; }
     public int Value { get; private set ; }


    public Cell()
    {
        X = 0;
        Y = 0;
        Value = 0;
    }

    public Cell(int x, int y, int value)
    {
        X = x;
        Y = y;
        Value = value;
    }

    internal void SetValue (int value) 
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
