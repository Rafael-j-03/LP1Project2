using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic.Cards
{
    public class BlueSteel : ICard
    {
        public string Name => "Blue Steel";
        public int C => 2;
        public int AP => 2;
        public int DP { get; set; } = 2;
        public int Quantity => 2;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}