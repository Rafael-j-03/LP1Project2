using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class FlyingWand : ICard
    {
        public string Name => "Flying Wand";
        public int C => 1;
        public int AP => 1;
        public int DP { get; set; } = 1;
        public int Quantity => 4;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}