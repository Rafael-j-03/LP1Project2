using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class MysticalRockWall : ICard
    {
        public string Name => "Mystical Rock Wall";
        public int C => 2;
        public int AP => 0;
        public int DP { get; set; } = 5;
        public int Quantity => 2;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}