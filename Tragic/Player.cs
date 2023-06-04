using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class Player
    {
        public int HP { get;}
        public int MP { get;}
        public List<Card> Deck { get; }

        public Player(int hp, int mp, List<Card> deck)
        {
            HP = hp;
            MP = mp;
            Deck = deck;
        }
    }
}