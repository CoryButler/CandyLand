namespace CandyLand
{
    public class PathExitTile : Tile
    {
        public string PathId { get; private set; }

        public PathExitTile(string id, string pathId)
        {
            Id = id;
            PathId = pathId;
        }
    }
}
