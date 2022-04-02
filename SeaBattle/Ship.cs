
    internal class Ship

    {
    private int [,] _coordinats { get; }
    public int Leght { get; }
    private ShipLocate _shipLocate;
    public bool Live { get; private set; }


    public Ship (int x, int y, int leght, ShipLocate shipLocate ) 
    {
        Leght = leght;
        _shipLocate = shipLocate;
        Live = true;
        _coordinats = new int[leght,2];

        for (int i = 0; i < leght; i++)
        {
            if (_shipLocate == ShipLocate.Horizontal)
            {
                _coordinats[i , 0] = x + i;
                _coordinats[i , 1] = y;
            }
            else
            {
                _coordinats[i, 0] = x;
                _coordinats[i, 1] = y + i;                
            }
        }
    }
    public int GetX (int pos)
    {
        if (pos > Leght -1) 
        {
            return -1;
        } 
        else 
        {
            return _coordinats[pos, 0];
        }
        
    }
    public int GetY(int pos)
    {
        if (pos > Leght - 1)
        {
            return -1;
        }
        else
        {
            return _coordinats[pos, 1];
        }
    }
}

