namespace Domino;

///<summary> Sorts Pieces according to their base left value </summary>
public class SortedByLeft : IComparer<Piece>
{
    public int Compare(Piece? a, Piece? b)
    {
        return (a, b) switch
        {
            (Piece h, Piece q) when a == null => -1,
            (Piece h, Piece q) when b == null => 1,
            (Piece h, Piece q) when a.Left > b.Left => 1,
            (Piece h, Piece q) when a.Left == b.Left => 0,
            (Piece h, Piece q) when a.Left < b.Left => -1,
            _ => throw new Exception("This shouldn't happen")
        };
    }
}