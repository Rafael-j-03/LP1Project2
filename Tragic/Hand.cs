using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class Hand
    {
        private List<ICard> cards;
        private Deck deck;
        private const int MaxHandSize = 6;

        public Hand(Deck deck)
        {
            this.deck = deck;
            cards = new List<ICard>();
            DrawInitialCards();
        }

        public void DrawInitialCards()
        {
            while (cards.Count < MaxHandSize && deck.GetCards().Count > 0)
            {
                DrawCard();
            }
        }

        public void DrawCard()
        {
            if (cards.Count < MaxHandSize)
            {
                if (deck.GetCards().Count > 0)
                {
                    ICard card = deck.GetCards()[0];
                    cards.Add(card);
                    deck.RemoveCard(card);
                }
                else
                {
                    // TODO: Handle empty deck
                }
            }
        }

        public void RemoveCard(ICard card)
        {
            cards.Remove(card);
        }

        public List<ICard> GetCards()
        {
            return cards;
        }
    }
}