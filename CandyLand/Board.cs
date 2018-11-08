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
            Tiles.Add(new PathEnterenceTile(TileImages.ORANGE, Paths.RAINBOW_TRAIL)); // Rainbow Path
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
            Tiles.Add(new PathEnterenceTile(TileImages.PURPLE, Paths.GUMDROP_PASS)); // Gumdrop Pass
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
            Tiles.Add(new PathExitTile(TileImages.PURPLE, Paths.GUMDROP_PASS)); // Gumdrop Pass Exit
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
            Tiles.Add(new PathExitTile(TileImages.PURPLE, Paths.RAINBOW_TRAIL)); // Rainbow Path Exit
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
            Tiles.Add(new CharacterTile(TileImages.GRAMMA_NUTT)); // Gramma Nut
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
                for (int i = 0; i < Tiles.Count; i++)
                {
                    if (Tiles[i].TileImage == card.Targets[0].TileImage) player.BoardIndex = i;
                }
                Console.WriteLine("{0} visits {1}.\t\tBoard Index: {2}", player.Name, card.Targets[0].TileImage, player.BoardIndex);
            }
            else
            {
                // TODO: Clean up win condition checking
                foreach (Tile target in card.Targets)
                {
                    player.BoardIndex++;
                    if (player.BoardIndex == Tiles.Count)
                    {
                        Console.WriteLine("{0} tries to move to {1} but reaches the castle instead.", player.Name, card.Targets[0].TileImage);
                        player.DidWin = true;
                        return;
                    }

                    while (Tiles[player.BoardIndex].TileImage != card.Targets[0].TileImage)
                    {
                        player.BoardIndex++;
                        if (player.BoardIndex == Tiles.Count)
                        {
                            Console.WriteLine("{0} tries to move to {1} but reaches the castle instead.", player.Name, card.Targets[0].TileImage);
                            player.DidWin = true;
                            return;
                        }
                    }
                    Console.WriteLine("{0} moves to {1}.\t\tBoard Index: {2}", player.Name, card.Targets[0].TileImage, player.BoardIndex);
                }
            }
            
            if (Tiles[player.BoardIndex] is PathEnterenceTile)
            {
                for (int i = 0; i < Tiles.Count; i++)
                {
                    if (Tiles[i] is PathExitTile)
                        if (((PathExitTile)Tiles[i]).Path == ((PathEnterenceTile)Tiles[player.BoardIndex]).Path)
                        {
                            player.BoardIndex = i;
                            break;
                        }
                }
                Console.WriteLine("{0} takes the {1}\t\tBoard Index: {2}.", player.Name, ((PathExitTile)Tiles[player.BoardIndex]).Path, player.BoardIndex);
            }

            if (Tiles[player.BoardIndex] is StickyTile)
            {
                player.IsStuck = true;
                Console.WriteLine("{0} gets stuck.\t\tBoard Index: {1}", player.Name, player.BoardIndex);
            }
        }
    }
}
