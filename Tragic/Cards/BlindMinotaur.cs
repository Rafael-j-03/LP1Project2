using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Blind Minotaur card
    /// </summary>
    public class BlindMinotaur : ICard
    {
        public string Name => "Blind Minotaur";
        public int C => 3;
        public int AP => 1;
        public int DP { get; set; } = 3;
        public int Quantity => 1;

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