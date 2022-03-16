





public class Board : Cell
{
    private int SizeX;
    private int SizeY;
    internal List<Cell> Boards { get; set; }
    internal errors Errors = errors.NoErrors;
    

    public Board (int sizeX, int sizeY, int value = 0) 
    {
        SizeX = sizeX;
        SizeY = sizeY;
        Boards = new List<Cell> (sizeX*sizeY);
        for (int i = 0; i < SizeX; i++) 
        {
            for (int j = 0; j < SizeY; j++)
            {
                Boards.Add(new Cell(i, j, value));
            }
        }
        
    }
    private  Board GetCell(int X, int Y)
    {
        var tmp = Boards.Find (x => x.X == X && x.Y == Y);
        if (tmp == null) { Errors = errors.Null;}
        return tmp;
        
    }
    
    public bool SetValue (int X, int Y, int Value) 
    {
        GetCell(X, Y);
        if (Errors == errors.Null) { Errors = errors.NoErrors; return false; } 
        Board.GetCell(X, Y).Value(Boards) = Value ;
        
        
        
        
        return true;
    }



}