using System.ComponentModel;





static class  Output
{
    static public void CReset (int x = 0, int y = 0 )
    {
        Console.Clear();
    }

    static public void CPrint(int x, int y, CellStatus value)
        {
        SetColor (value);
        Console.CursorLeft = x;
        Console.CursorTop = y;
        Console.Write ( Convert.ToChar ( GetDescripton (value  )));
        Console.ResetColor();
        }
    
    static public void CPrint(int x, int y, char value, ConsoleColor fontColor = ConsoleColor.Gray, ConsoleColor backColor = ConsoleColor.Black)
    {
        Console.ForegroundColor = fontColor;
        Console.BackgroundColor = backColor;
        Console.CursorLeft = x;
        Console.CursorTop = y;
        Console.Write(value);
        Console.ResetColor();
    }
    static private string GetDescripton (Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var description = field?.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
        if (description != null)
        {
            return description.First().Description;
        }
        return value.ToString();
    }    
    static private void SetColor (CellStatus value)
    {
        if (value == CellStatus.Ship)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
        }
    }
}