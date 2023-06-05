using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Hand class
    /// </summary>
    public class Hand
    {
        private List<ICard> cards;
        private Deck deck;
        private const int MaxHandSize = 6;

        /// <summary>
        /// Constructor for the hand
        /// </summary>
        /// <param name="deck">Deck from the player</param>
        public Hand(Deck deck)
        {
            this.deck = deck;
            cards = new List<ICard>();
            DrawInitialCards();
        }

        /// <summary>
        /// Draw initial cards
        /// </summary>
        public void DrawInitialCards()
        {
            while (cards.Count < MaxHandSize && deck.GetCards().Count > 0)
            {
                DrawCard();
            }
        }

        /// <summary>
        /// Draw a card
        /// </summary>
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

        /// <summary>
        /// Remove card from the hand
        /// </summary>
        /// <param name="card">Selected card</param>
        public void RemoveCard(ICard card)
        {
            cards.Remove(card);
        }

        /// <summary>
        /// Get the cards from the hand
        /// </summary>
        /// <returns>All the cards from the hand</returns>
        public List<ICard> GetCards()
        {
            return cards;
        }
    }
}