using UnityEngine;

public class BoardManager 
{
    
}

public class BoardData
{
    private int[,] _board;
    private readonly Vector2Int _boardSize = new Vector2Int(10,20);

    public BoardData()
    {
        _board = new int[_boardSize.x, _boardSize.y];
    }

    public BoardData(Vector2Int boardSize)
    {
        _boardSize = boardSize;
        _board = new int[_boardSize.x, _boardSize.y];
    }

    public void SetPiece(int[,] pieceData, int posX, int posY)
    {
        if (_board.GetLength(0) <= posX + pieceData.GetLength(0) || _board.GetLength(1) <= posY + pieceData.GetLength(1))
        {
            Debug.LogWarning("Invalid board size");
            return;
        }
        
        
    }
}
