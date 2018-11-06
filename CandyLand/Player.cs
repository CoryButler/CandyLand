using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLand
{
    public enum PlayerColors { RED, YELLOW, GREEN, BLUE };

    public class Player
    {
        public readonly string Name;
        public readonly int Age;
        public readonly PlayerColors Color;
        public int BoardIndex { get; set; } = -1;
        public bool DidWin { get; set; } = false;
        public bool IsStuck { get; set; } = false;

        public Player(string name, int age, PlayerColors color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void UseCard(Card card)
        {
            // TODO: Move the player to the correct tile.
            // get destination
            // if isColor
            //      if !destinationExists winGame()
            //      else goToDestination()
            //      if destinationIsSecretPath
            //          takeSecretPath()
            // else
            //      goToCharacter
        }
    }
}
