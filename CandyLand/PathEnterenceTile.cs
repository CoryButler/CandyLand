namespace CandyLand
{
    public class PathEnterenceTile : Tile
    {
        public string PathId { get; private set; }

        public PathEnterenceTile(string id, string pathId)
        {
            Id = id;
            PathId = pathId;
        }
    }
}
