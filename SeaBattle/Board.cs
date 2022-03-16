





public class Board : Cell
{
    private int SizeX = 10;
    private int SizeY = 10;
    public List<Cell> Boards { get; private set; }

    public Board (int sizeX, int sizeY, int value = 0) 
    {
        SizeX = sizeX;
        SizeY = sizeY;
        Boards = new List<Cell> ();
        for (int i = 0; i < SizeX; i++) 
        {
            for (int j = 0; j < SizeY; j++)
            {
                Boards.Add(new Cell(i, j, value));
            }
        }
        
    }
    public bool SetValue (int X, int Y, int Value) 
    {
        var Index = Boards.Find(x => x.X == X && x.Y == Y);
        Index.Draft();



        return true;
    }
    
}