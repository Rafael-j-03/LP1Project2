using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Player class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Player number
        /// </summary>
        /// <value></value>
        public string PlayerNumber { get; set; }

        /// <summary>
        /// Player HP
        /// </summary>
        /// <value></value>
        public int HP { get; set; }

        /// <summary>
        /// Player MP
        /// </summary>
        /// <value></value>
        public int MP { get; set; }

        /// <summary>
        /// Player deck
        /// </summary>
        /// <value></value>
        public Deck Deck { get; }

        /// <summary>
        /// Player hand
        /// </summary>
        /// <value></value>
        public Hand Hand { get; }

        /// <summary>
        /// Player selected cards
        /// </summary>
        /// <value></value>
        public SelectedCards SelectedCards { get; }

        /// <summary>
        /// Constructor for the player
        /// </summary>
        /// <param name="PlayerNumber">Player Number</param>
        /// <param name="hp">Player Health Points</param>
        /// <param name="mp">Player Mana Points</param>
        /// <param name="deck">Player Deck</param>
        public Player(string PlayerNumber, int hp, int mp, Deck deck)
        {
            this.PlayerNumber = PlayerNumber;
            HP = hp;
            MP = mp;
            Deck = deck;
            Hand = new Hand(deck);
            SelectedCards = new SelectedCards(Hand);
        }
    }
}