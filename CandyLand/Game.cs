using System;
using System.Collections.Generic;

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

        public Game()
        {
            // TODO: Ready users' physical deck from TXT data file.
            _drawDeck.Initialize();
            _drawDeck.Shuffle();
            _drawDeck.Shuffle();
            _drawDeck.Shuffle();
            _drawDeck.Shuffle();
            _drawDeck.Shuffle();
            SetUpPlayers();
            Play();
            Results();
        }

        private void SetUpPlayers()
        {
            // TODO: add 2 to 4 players starting with youngest and moving left around the board
            _players.Add(new Player("Emma  ", 5, PlayerColors.RED));
            _players.Add(new Player("Cory  ", 30, PlayerColors.GREEN));
            _players.Add(new Player("Katrin", 36, PlayerColors.BLUE));
            _players.Add(new Player("Flo   ", 35, PlayerColors.YELLOW));
        }

        private void Play()
        {
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

        private void RestoreDrawDeck()
        {
            Console.WriteLine("\nRestoring Draw Deck\n");
            _drawDeck.Shuffle(_discardDeck);
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
