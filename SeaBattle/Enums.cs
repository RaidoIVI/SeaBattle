using System.ComponentModel;

public enum Errors
{
    NoErrors,
    Null,

}

public enum ShipLocate
{
    Horizontal,
    Vertical,
}
public enum CellStatus
{
    [Description("O")]

    Empty,
    [Description("X")]
    Ship,
    [Description("O")]
    Forbidden,

}

