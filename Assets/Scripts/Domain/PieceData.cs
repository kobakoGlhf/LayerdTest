
public class PieceData
{
    #region PieceSizeData
    public static readonly int[,] IPiece = new int[,]
    {
        {1},
        {1},
        {1},
        {1}
    };
    public static readonly int[,] JPiece = new int[,]
    {
        {1, 0, 0},
        {1, 1, 1}
    };

    public static readonly int[,] LPiece = new int[,]
    {
        { 0, 0, 1 },
        { 1, 1, 1 }
    };
    public static readonly int[,] OPiece = new int[,]
    {
        { 1, 1 },
        { 1, 1 }
    };

    public static readonly int[,] SPiece = new int[,]
    {
        { 0, 1, 1 },
        { 1, 1, 0 }
    };
    public static readonly int[,] ZPiece = new int[,]
    {
        { 1, 1, 0 },
        { 0, 1, 1 }
    };
    
    
    public static readonly int[,] TPiece = new int[,]
    {
        { 1, 1, 1 },
        { 0, 1, 0 }
    };
    #endregion
    
}
