namespace CandyLand
{
    public class PathExitTile : Tile
    {
        public Paths Path { get; private set; }

        public PathExitTile(TileImages tileImage, Paths path)
        {
            TileImage = tileImage;
            Path = path;
        }
    }
}
