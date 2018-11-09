namespace CandyLand
{
    public class Player
    {
        public readonly string Name;
        public readonly string Color;
        public int BoardIndex { get; set; } = -1;
        public bool DidWin { get; set; } = false;
        public bool IsStuck { get; set; } = false;

        public Player(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
