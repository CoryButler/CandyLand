using System;
using System.Collections.Generic;

namespace CandyLand
{
    public class Board
    {
        public List<Tile> Tiles { get; } = new List<Tile>();

        public Board()
        {
            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new PathEnterenceTile(TileImages.ORANGE, Paths.RAINBOW)); // Rainbow Path
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new CharacterTile(TileImages.PLUMPY)); // Plumpy
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new CharacterTile(TileImages.MR_MINT)); // Mr. Mint
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new PathEnterenceTile(TileImages.PURPLE, Paths.GUMDROP)); // Gumdrop Pass
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new CharacterTile(TileImages.JOLLY)); // Jolly
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new PathExitTile(TileImages.PURPLE, Paths.GUMDROP)); // Gumdrop Pass Exit
            Tiles.Add(new StickyTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new PathExitTile(TileImages.PURPLE, Paths.RAINBOW)); // Rainbow Path Exit
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new CharacterTile(TileImages.GRAMMA_NUT)); // Gramma Nut
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new StickyTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));
            
            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new CharacterTile(TileImages.PRINCESS_LOLLY)); // Princess Lolly
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new CharacterTile(TileImages.QUEEN_FROSTINE)); // Queen Frostine
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new StickyTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            Tiles.Add(new ColorTile(TileImages.PURPLE));
            Tiles.Add(new ColorTile(TileImages.YELLOW));
            Tiles.Add(new ColorTile(TileImages.BLUE));
            Tiles.Add(new ColorTile(TileImages.ORANGE));
            Tiles.Add(new ColorTile(TileImages.GREEN));

            Tiles.Add(new ColorTile(TileImages.RED));
            //Tiles.Add(new ColorTile(TileImages.PURPLE)); // Rainbow Tile
        }

        public void UseCard(Player player, Card card)
        {
            if (card.Targets[0] is CharacterTile)
            {
                player.BoardIndex = Tiles.IndexOf(card.Targets[0]);
            }
            else
            {
                // TODO: Clean up win condition checking
                foreach (Tile target in card.Targets)
                {
                    player.BoardIndex++;
                    if (player.BoardIndex == Tiles.Count)
                    {
                        player.DidWin = true;
                    }

                    while (Tiles[player.BoardIndex] != card.Targets[0])
                    {
                        player.BoardIndex++;
                        if (player.BoardIndex == Tiles.Count)
                        {
                            player.DidWin = true;
                        }
                    }
                }
            }
        }
    }
}
