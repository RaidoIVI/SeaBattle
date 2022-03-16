





 static class  Output
{
    static public void CSet (int x = 0, int y = 0 )
    {
        Console.Clear();
    //    //Console.CursorSize = 100;
    //    Console.SetWindowSize (x, y);
    //    Console.SetBufferSize (x, y);
    //    //Console.CursorVisible = false;
    }

    static public void CPrint(int x, int y, int value, ConsoleColor fontColor = ConsoleColor.Gray, ConsoleColor backColor = ConsoleColor.Black)
        {
        Console.ForegroundColor = fontColor;
        Console.BackgroundColor = backColor;
        Console.CursorLeft = x;
        Console.CursorTop = y;
        Console.Write (value);
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

}