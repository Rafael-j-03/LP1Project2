using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class SelectedCards
    {
        private List<ICard> cards;
        private Hand hand;

        public SelectedCards(Hand hand)
        {
            this.hand = hand;
            cards = new List<ICard>();
        }

        public void AddCard(ICard card)
        {
            cards.Add(card);
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