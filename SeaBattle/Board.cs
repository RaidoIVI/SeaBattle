





public class Board
{
    private int SizeX;
    private int SizeY;
    public List<Cell> Boards { get; private set; }
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


   
    
   



}