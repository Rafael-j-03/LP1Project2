using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class Player
    {
        public int HP { get; set; }
        public int MP { get; set; }
        public Deck Deck { get; }
        public Hand Hand { get; }

        public Player(int hp, int mp, Deck deck)
        {
            HP = hp;
            MP = mp;
            Deck = deck;
            Hand = new Hand(deck);
        }
    }
}