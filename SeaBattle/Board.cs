public class Board
{
    private int _sizeX;
    private int _sizeY;
    private readonly List<Cell> _boards;
    internal Errors errors = Errors.NoErrors;


    public Board(int sizeX, int sizeY)
    {
        _sizeX = sizeX;
        _sizeY = sizeY;
        _boards = new List<Cell>(sizeX * sizeY);
        BoardInit(sizeX, sizeY);
    }

    private void BoardInit (int SizeX, int SizeY ) 
    {
        _boards.Clear();
        for (int i = 0; i < SizeX; i++)
        {
            for (int j = 0; j < SizeY; j++)
            {
                _boards.Add(new Cell(i, j));
            }
        }
    }
        
    internal bool ShipAdd (Ship ship)  
    {
        if ( Collision(ship) ) 
        {
            for (int i = 0; i < ship.Leght ; i++)
            {
                var tmp = new Cell();
                var x = ship.GetX(i);
                var y = ship.GetY(i);
                tmp = _boards.Find( c => c.X == x && c.Y == y )  ;
                if (tmp != null) 
                {
                    tmp.SetValue(CellStatus.Ship); 
                }
                else
                {
                    return false;
                }                
            }
        }  
        CollisionBoardReset();
        return true;
    } 

    public void Draft()
    {
        foreach (var cell in _boards)
        {
            cell.Draft();
        }
    }
  
    private bool Collision (int X, int Y) 
    {
        return _boards.Contains(new Cell(X,Y,CellStatus.Empty));       
    }

    private bool Collision (Ship ship) 
    {
        for (int i = 0; i < ship.Leght  ;i++)
        {
            if (Collision (ship.GetX(i),ship.GetY(i))) 
            {
                return false;
            }
        }
        return true;
    }
    private void CollisionCellReset(Cell cell)
    {
        if (cell.Value == CellStatus.Ship)
        {
            for (int i=-1; i<2; i++)
            {
                for (int j=-1; j<2; j++)
                {
                    var tmp = _boards.Find(c => c.X == cell.X+i && c.Y == cell.Y+j);
                    if (tmp != null)
                    {
                        if (tmp.Value != CellStatus.Ship)
                        {
                            tmp.Value = CellStatus.Forbidden;
                        }
                    }
                }
            }
        }        
    }

    private void CollisionBoardReset ()
    {
        foreach (var cell in _boards)
        {
            CollisionCellReset (cell);
        }
    }
}