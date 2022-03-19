
    internal class Ship : Cell

    {
    int X;
    int Y;
    int Leght;
    bool Live;
    public List<Cell> Ships { get; private set; }

    public Ship (int x, int y, int leght, ShipLocate shipLocate ) 
    {
        for (int i=0; i<leght; i++) 
        {
            if (shipLocate == ShipLocate.Horizontal)
            {
                Ships.Add (new Cell (x+i, y, CellStatus.Ship));
            }
            else
            {
                Ships.Add (new Cell (x, y+i, CellStatus.Ship));
            }
        }
    }

    }

