namespace Domino;

public class OnlyEvenDoublesPiece : Piece
{
    public OnlyEvenDoublesPiece(int left, int right)
    {
        Left = left;
        Right = right;
    }
    public override bool CanPlay(Board board)
    {
        var temp = new RegularPiece(Left, Right);
        if (Left == Right)
        {
            if (board.PiecesOnBoard!.Count() % 2 == 0) return temp.CanPlay(board);
            return false;
        }
        return temp.CanPlay(board);
    }
    public override bool MatchRight(int num) => Right == num;
    public override bool MatchLeft(int num) => Left == num; 
}