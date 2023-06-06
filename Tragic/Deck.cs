using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tragic
{
    /// <summary>
    /// Deck class
    /// </summary>
    public class Deck
    {
        private List<ICard> cards;
        private const int MaxDeckSize = 20;

        /// <summary>
        /// Constructor for the deck
        /// </summary>
        public Deck()
        {
            cards = new List<ICard>();
            AddCardsFromAssembly();

            // Shuffle the cards
            Shuffle(cards);

            // Trim the deck if it exceeds the maximum size
            if (cards.Count > MaxDeckSize)
            {
                cards = cards.Take(MaxDeckSize).ToList();
            }
        }

        /// <summary>
        /// Add cards from the assembly
        /// </summary>
        //(We searched the web for how to use Assembly and Activator,
        // and we clarified it in ChatGPT)
        private void AddCardsFromAssembly()
        {
            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly(); 
            // Get all types that implement ICard
            var cardTypes = assembly.GetTypes().Where
                                (t => t.GetInterfaces().Contains(typeof(ICard)));

            foreach (Type cardType in cardTypes)
            {
                // Create an instance of the card type
                ICard card = Activator.CreateInstance(cardType) as ICard; 
                // Add the card to the deck respecting its quantity
                AddCards(card, card.Quantity); 
            }
        }

        /// <summary>
        /// Add cards to the deck
        /// </summary>
        /// <param name="card">Selected card</param>
        /// <param name="quantity">Quantity from the selected card</param>
        private void AddCards(ICard card, int quantity)
        {
            int remainingSpace = MaxDeckSize - cards.Count;
            int numToAdd = Math.Min(quantity, remainingSpace);
            
            for (int i = 0; i < numToAdd; i++)
            {
                cards.Add(card);
            }
        }

        /// <summary>
        /// Shuffle the cards
        /// </summary>
        /// <param name="cards">List of cards</param>
        private void Shuffle(List<ICard> cards)
        {
            // Shuffle the cards
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int i = random.Next(n + 1);
                ICard card = cards[i];
                cards[i] = cards[n];
                cards[n] = card;
            }
        }

        /// <summary>
        /// Remove card from the deck
        /// </summary>
        /// <param name="card">Selected card</param>
        public void RemoveCard(ICard card)
        {
            cards.Remove(card);
        }

        /// <summary>
        /// Get cards from the deck
        /// </summary>
        /// <returns>All the cards from the deck</returns>
        public List<ICard> GetCards()
        {
            return cards;
        }
    }
}