using System.Collections.Generic;

namespace CandyLand
{
    public class Card
    {
        public readonly List<Tile> Targets = new List<Tile>();

        public Card(List<Tile> targets)
        {
            Targets = targets;
        }
    }
}
