using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyLand
{
    public enum TileImages { RED, PURPLE, YELLOW, BLUE, ORANGE, GREEN, GRAMMA_NUTT, JOLLY, MR_MINT, PLUMPY, PRINCESS_LOLLY, QUEEN_FROSTINE };
    public enum Paths { GUMDROP_PASS, RAINBOW_TRAIL };

    public class Game
    {
        private bool _isGameOver = false;
        private int _currentPlayer = 0;

        private Board _board = new Board();
        private Deck _drawDeck = new Deck();
        private Deck _discardDeck = new Deck();
        private List<Player> _players = new List<Player>();
        private List<string> _availablePlayerColors = new List<string>() { "blue", "green", "red", "yellow" };

        public Game()
        {
            Console.WriteLine("Candy Land");
            SetUpDeck();
            //_drawDeck.Initialize();
            //_drawDeck.Shuffle();
            //_drawDeck.Shuffle();
            //_drawDeck.Shuffle();
            //_drawDeck.Shuffle();
            //_drawDeck.Shuffle();
            SetUpPlayers();
            Play();
            Results();
        }

        // TODO: SetUpDeck() has no error checking.
        private void SetUpDeck()
        {
            Console.WriteLine("\nEnter deck info:\nr - red    \tR - double red\no - orange \tO - double orange\ny - yellow \tY - double yellow\ng - green  \tG - double green\nb - blue   \tB - double blue\np - purple \tP - double purple\n1 - Plumpy\n2 - Mr. Mint\n3 - Jolly\n4 - Gramma Nutt\n5 - Princess Lolly\n6 - Queen Frostine\n");
            //_drawDeck.ParseString("rrrrrrrroooooooyyyyyyyygggggggbbbbbbbbppppppppRROOYYGGBBPP123456");
            _drawDeck.ParseString(Console.ReadLine());
        }

        // TODO: SetUpPlayers sucks.
        private void SetUpPlayers()
        {
            string inputNumPlayers;
            Console.WriteLine("\nHow many players are there? (2–4)");
            inputNumPlayers = Console.ReadLine();

            while (inputNumPlayers != "2" && inputNumPlayers != "3" && inputNumPlayers != "4")
            {
                Console.WriteLine("\nHow many players are there? (2–4)");
                inputNumPlayers = Console.ReadLine();
            }

            int numPlayers = int.Parse(inputNumPlayers);

            Console.WriteLine("\nWho is the youngest player?");
            string name = Console.ReadLine();
            
            string availablePlayerColors = string.Join(", ", _availablePlayerColors);
            Console.WriteLine("\nWhich color will {0} be? ({1})", name, availablePlayerColors);
            string color = Console.ReadLine();

            while (!_availablePlayerColors.Any(c => c == color))
            {
                availablePlayerColors = string.Join(", ", _availablePlayerColors);
                Console.WriteLine("\nWhich color will {0} be? ({1})", name, availablePlayerColors);
                color = Console.ReadLine();
            }

            _availablePlayerColors.Remove(color);
            _players.Add(new Player(name, color));

            for (int i = 1; i < numPlayers; i++)
            {
                Console.WriteLine("\nWho sits to the left of {0}?", name);
                name = Console.ReadLine();


                if (_availablePlayerColors.Count == 1) color = _availablePlayerColors[0];
                else
                {
                    availablePlayerColors = string.Join(", ", _availablePlayerColors);
                    Console.WriteLine("\nWhich color will {0} be? ({1})", name, availablePlayerColors);
                    color = Console.ReadLine();

                    while (!_availablePlayerColors.Any(c => c == color))
                    {
                        availablePlayerColors = string.Join(", ", _availablePlayerColors);
                        Console.WriteLine("\nWhich color will {0} be? ({1})", name, availablePlayerColors);
                        color = Console.ReadLine();
                    }
                }
                
                _availablePlayerColors.Remove(color);
                _players.Add(new Player(name, color));
            }
        }

        private void Play()
        {
            Console.WriteLine("\nLet's play!\n");
            _currentPlayer = _players.Count - 1;

            while (!_isGameOver)
            {
                _currentPlayer = NextPlayerIndex();
            
                if (_players[_currentPlayer].IsStuck)
                {
                    Console.WriteLine("{0} is stuck!", _players[_currentPlayer].Name);
                    _players[_currentPlayer].IsStuck = false;
                }
                else
                {
                    if (IsDrawDeckEmpty()) RestoreDrawDeck();

                    Card card = _drawDeck.RemoveCard();
                    _board.UseCard(_players[_currentPlayer], card);
                    _discardDeck.AddCard(card);

                    _isGameOver = _players[_currentPlayer].DidWin;
                }
            }
        }

        private bool IsDrawDeckEmpty()
        {
            return _drawDeck.Cards.Count == 0;
        }
        
        // TODO: RestoreDrawDeck() has no error checking.
        private void RestoreDrawDeck()
        {
            //Console.WriteLine("\nRestoring Draw Deck\n");
            //_drawDeck.Shuffle(_discardDeck);
            Console.WriteLine("\nShuffle the deck and enter card info:\n");
            _drawDeck.ParseString(Console.ReadLine());
            _discardDeck.Clear();
        }

        private int NextPlayerIndex()
        {
            return (_currentPlayer + 1) % _players.Count;
        }

        private void Results()
        {
            Console.Write("\n{0} wins!", _players[_currentPlayer].Name);
            Console.ReadLine();
        }
    }
}
