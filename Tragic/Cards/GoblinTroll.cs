using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Goblin Troll card
    /// </summary>
    public class GoblinTroll : ICard
    {
        public string Name => "Goblin Troll";
        public int C => 3;
        public int AP => 3;
        public int DP { get; set; } = 2;
        public int Quantity => 2;

        /// <summary>
        /// Override ToString() to display the card's Name/C/AP/DP
        /// </summary>
        /// <returns>The characteristics from the card</returns>
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}