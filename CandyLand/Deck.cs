using System;
using System.Collections.Generic;

namespace CandyLand
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        public List<Card> Cards { get { return _cards; } }

        public void Initialize()
        {
            for (int i = 0; i < 8; i++)
            {
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.RED) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.YELLOW) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.BLUE) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.PURPLE) }));
            }
            for (int i = 0; i < 7; i++)
            {
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.ORANGE) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.GREEN) }));
            }
            for (int i = 0; i < 2; i++)
            {
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.RED), new ColorTile(TileImages.RED) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.ORANGE), new ColorTile(TileImages.ORANGE) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.YELLOW), new ColorTile(TileImages.YELLOW) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.GREEN), new ColorTile(TileImages.GREEN) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.BLUE), new ColorTile(TileImages.BLUE) }));
                _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.PURPLE), new ColorTile(TileImages.PURPLE) }));
            }
            _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.PLUMPY) }));
            _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.MR_MINT) }));
            _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.JOLLY) }));
            _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.GRAMMA_NUTT) }));
            _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.PRINCESS_LOLLY) }));
            _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.QUEEN_FROSTINE) }));
        }

        public void ParseString(string cardData)
        {
            string ataDdrac = string.Empty;
            int charsRemaining = cardData.Length;

            while (charsRemaining > 0)
            {
                ataDdrac += cardData[charsRemaining - 1];
                charsRemaining--;
            }

            foreach (char c in ataDdrac)
            {
                switch (c)
                {
                    case 'r':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.RED) }));
                        break;
                    case 'o':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.ORANGE) }));
                        break;
                    case 'y':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.YELLOW) }));
                        break;
                    case 'g':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.GREEN) }));
                        break;
                    case 'b':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.BLUE) }));
                        break;
                    case 'p':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.PURPLE) }));
                        break;
                    case 'R':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.RED), new ColorTile(TileImages.RED) }));
                        break;
                    case 'O':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.ORANGE), new ColorTile(TileImages.ORANGE) }));
                        break;
                    case 'Y':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.YELLOW), new ColorTile(TileImages.YELLOW) }));
                        break;
                    case 'G':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.GREEN), new ColorTile(TileImages.GREEN) }));
                        break;
                    case 'B':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.BLUE), new ColorTile(TileImages.BLUE) }));
                        break;
                    case 'P':
                        _cards.Add(new Card(new List<Tile>() { new ColorTile(TileImages.PURPLE), new ColorTile(TileImages.PURPLE) }));
                        break;
                    case '1':
                        _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.PLUMPY) }));
                        break;
                    case '2':
                        _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.MR_MINT) }));
                        break;
                    case '3':
                        _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.JOLLY) }));
                        break;
                    case '4':
                        _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.GRAMMA_NUTT) }));
                        break;
                    case '5':
                        _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.PRINCESS_LOLLY) }));
                        break;
                    case '6':
                        _cards.Add(new Card(new List<Tile>() { new CharacterTile(TileImages.QUEEN_FROSTINE) }));
                        break;
                }
            }
        }

        public void Clear()
        {
            _cards = new List<Card>();
        }

        public Card RemoveCard()
        {
            Card card = _cards[_cards.Count - 1];
            _cards.RemoveAt(_cards.Count - 1);
            return card;
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void Shuffle(Deck deck = null)
        {
            if (deck == null) deck = this;

            Random random = new Random();

            int numCardsRemaining = deck.Cards.Count;
            List<Card> cards = deck.Cards;

            while (numCardsRemaining > 1)
            {
                numCardsRemaining--;
                int randomIndex = random.Next(numCardsRemaining + 1);
                Card tempCard = cards[randomIndex];
                cards[randomIndex] = cards[numCardsRemaining];
                cards[numCardsRemaining] = tempCard;
            }

            _cards = cards;
        }
    }
}
