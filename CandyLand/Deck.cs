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
            // TODO: build default deck
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
        }
    }
}
