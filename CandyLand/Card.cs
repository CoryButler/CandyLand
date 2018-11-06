using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLand
{
    public enum Destinations { RED, ORANGE, YELLOW, GREEN, BLUE, PURPLE, GRAMMA_NUT, JOLLY, MR_MINT, PLUMPING, PRINCESS_LOLLY, QUEEN_FROSTINE };
    public class Card
    {
        private readonly Destinations _destination;
        public readonly List<string> TargetTiles = new List<string>();

        public Card(Destinations destination, List<string> targetTile)
        {
            _destination = destination;
            TargetTiles = targetTile;
        }
    }
}
