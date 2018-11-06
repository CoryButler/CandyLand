using System;
using System.Collections.Generic;

namespace CandyLand
{
    public class Board
    {
        public List<Tile> Tiles { get; } = new List<Tile>();

        public Board()
        {
            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new PathEnterenceTile("Orange", "Rainbow")); // Rainbow Path
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new CharacterTile("Plumpy")); // Plumpy
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new CharacterTile("Mr. Mint")); // Mr. Mint
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new PathEnterenceTile("Purple", "Gumdrop")); // Gumdrop Pass
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new CharacterTile("Jolly")); // Jolly
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new PathExitTile("Purple", "Gumdrop")); // Gumdrop Pass Exit
            Tiles.Add(new StickyTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new PathExitTile("Purple", "Rainbow")); // Rainbow Path Exit
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new CharacterTile("Gramma Nut")); // Gramma Nut
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new StickyTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));
            
            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new CharacterTile("Princess Lolly")); // Princess Lolly
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new CharacterTile("Queen Frostine")); // Queen Frostine
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new StickyTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            Tiles.Add(new ColorTile("Purple"));
            Tiles.Add(new ColorTile("Yellow"));
            Tiles.Add(new ColorTile("Blue"));
            Tiles.Add(new ColorTile("Orange"));
            Tiles.Add(new ColorTile("Green"));

            Tiles.Add(new ColorTile("Red"));
            //Tiles.Add(new ColorTile("Purple")); // Rainbow Tile
        }

        public void UseCard(Player player, Card card)
        {
            player.BoardIndex++;
            if (player.BoardIndex == Tiles.Count)
            {
                player.DidWin = true;
                return;
            }

            // TODO: make character and enum
            if (card.TargetTiles[0] == "Plumpy")
            {
                player.BoardIndex = Tiles.IndexOf(new CharacterTile("Plumpy"));
            }

            foreach (string target in card.TargetTiles)
            {
                while (Tiles[player.BoardIndex].Id != card.TargetTiles[0])
                {
                    player.BoardIndex++;
                }
            }
        }
    }
}
