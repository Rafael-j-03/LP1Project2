using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tragic
{
    public class Deck
    {
        private List<ICard> cards;
        private const int MaxDeckSize = 20;

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

        private void AddCards(ICard card, int quantity)
        {
            int remainingSpace = MaxDeckSize - cards.Count;
            int numToAdd = Math.Min(quantity, remainingSpace);
            
            for (int i = 0; i < numToAdd; i++)
            {
                cards.Add(card);
            }
        }

        private void Shuffle(List<ICard> cards)
        {
            // Shuffle the cards
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                ICard card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        // Remove a card from the deck
        public void RemoveCard(ICard card)
        {
            cards.Remove(card);
        }

        // Get all current cards in the deck
        public List<ICard> GetCards()
        {
            return cards;
        }
    }
}
