using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyLand
{
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
            _drawDeck.Initialize();
            _drawDeck.Shuffle();
            SetUpPlayers();
            Play();
            Results();
        }

        private void SetUpPlayers()
        {
            // TODO: add 2 to 4 players
        }

        private void Play()
        {
            while (!_isGameOver)
            {
                if (_players[_currentPlayer].IsStuck)
                {
                    _players[_currentPlayer].IsStuck = false;
                }
                else
                {
                    if (IsDrawDeckEmpty()) RestoreDrawDeck();

                    Card card = _drawDeck.RemoveCard();
                    card.Actions();
                    _discardDeck.AddCard(card);

                    _isGameOver = _players[_currentPlayer].DidWin;
                }

                _currentPlayer = NextPlayerIndex();
            }
        }

        private bool IsDrawDeckEmpty()
        {
            return _drawDeck.Cards.Count == 0;
        }

        private void RestoreDrawDeck()
        {
            _drawDeck.Shuffle(_drawDeck);
            _discardDeck.Clear();
        }

        private int NextPlayerIndex()
        {
            return (_currentPlayer + 1) % _players.Count;
        }

        private void Results()
        {
            // TODO: Show results
        }
    }
}
