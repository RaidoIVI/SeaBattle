
using SeaBattle;

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

    private void BoardInit (int sizeX, int sizeY ) 
    {
        _boards.Clear();
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                _boards.Add(new Cell(i, j));
            }
        }
    }
        
    internal bool ShipAdd (Ship ship,Rulls rulls)  
    {
        if ( !Collision(ship) ) 
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
        else
        {
            return false;
        }
        CollisionBoardReset(rulls.GetCollisionRadius());
        return true;
    }

    private bool Collision(Ship ship)
    {
        for (int i = 0; i < ship.Leght; i++)
        {
            if (Collision(ship.GetX(i), ship.GetY(i)))
            {
                return true;
            }
        }
        return false;
    }

    private bool Collision (int x, int y) 
    {
        var tmp = _boards.Find(c => c.X == x && c.Y == y);    
        if (tmp == null)
        {
            return true;
        }
        else
        {
            if (tmp.Value != CellStatus.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    private void CollisionCellReset(Cell cell,int collisionRadius)
    {
        if (cell.Value == CellStatus.Ship)
        {
            for (int i=-collisionRadius; i<collisionRadius+1; i++)
            {
                for (int j=-collisionRadius; j<collisionRadius+1; j++)
                {
                    var tmp = _boards.Find(c => c.X == cell.X+i && c.Y == cell.Y+j);
                    if (tmp != null)
                    {
                        if (tmp.Value == CellStatus.Empty)
                        {
                            tmp.Value = CellStatus.Forbidden;
                        }
                    }
                }
            }
        }        
    }

    private void CollisionBoardReset (int collisionRadius)
    {
        foreach (var cell in _boards)
        {
            CollisionCellReset (cell, collisionRadius);
        }
    }

    public void Draft()
    {
        foreach (var cell in _boards)
        {
            cell.Draft();
        }
    }

    public void Draft(int X, int Y)
    {
        foreach (var cell in _boards)
        {
            cell.Draft(X, Y);
        }
    }
}