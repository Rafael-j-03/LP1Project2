using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class Player
    {
        public string PlayerNumber { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Deck Deck { get; }
        public Hand Hand { get; }
        public SelectedCards SelectedCards { get; }

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