namespace Domino;

public class RegularBoard : Board
{
    public RegularBoard()
    {
        PiecesOnBoard = new();
    }
    public override List<Piece> Generate(int maximumInput)
    {
        List<Piece> result = new();
        for (int i = 0; i <= maximumInput; i++)
        {
            for (int j = i; j <= maximumInput; j++)
            {
                var temp = new RegularPiece(i, j);
                result.Add(temp);
            }
        }
        return result;
    }
}