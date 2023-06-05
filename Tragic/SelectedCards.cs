using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Selected cards class
    /// </summary>
    public class SelectedCards
    {
        private List<ICard> cards;
        private Hand hand;

        /// <summary>
        /// Constructor for the selected cards
        /// </summary>
        /// <param name="hand">Current hand from the player</param>
        public SelectedCards(Hand hand)
        {
            this.hand = hand;
            cards = new List<ICard>();
        }

        /// <summary>
        /// Add card to the selected cards
        /// </summary>
        /// <param name="card">Card</param>
        public void AddCard(ICard card)
        {
            cards.Add(card);
        }

        /// <summary>
        /// Remove card from the selected cards
        /// </summary>
        /// <param name="card">Card</param>
        public void RemoveCard(ICard card)
        {
            cards.Remove(card);
        }

        /// <summary>
        /// Get the selected cards
        /// </summary>
        /// <returns>All the cards on the players selected cards</returns>
        public List<ICard> GetCards()
        {
            return cards;
        }
    }
}