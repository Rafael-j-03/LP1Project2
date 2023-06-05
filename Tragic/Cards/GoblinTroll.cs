using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class GoblinTroll : ICard
    {
        public string Name => "Goblin Troll";
        public int C => 3;
        public int AP => 3;
        public int DP { get; set; } = 2;
        public int Quantity => 2;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}