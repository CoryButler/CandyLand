namespace CandyLand
{
    public class PathEnterenceTile : Tile
    {
        public Paths Path { get; private set; }

        public PathEnterenceTile(TileImages tileImage, Paths path)
        {
            TileImage = tileImage;
            Path = path;
        }
    }
}
