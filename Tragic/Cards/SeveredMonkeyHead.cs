using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Severed Monkey Head card
    /// </summary>
    public class SeveredMonkeyHead : ICard
    {
        public string Name => "Severed Monkey Head";
        public int C => 1;
        public int AP => 2;
        public int DP { get; set; } = 1;
        public int Quantity => 4;

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