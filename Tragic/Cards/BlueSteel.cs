using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic.Cards
{
    /// <summary>
    /// Blue Steel card
    /// </summary>
    public class BlueSteel : ICard
    {
        public string Name => "Blue Steel";
        public int C => 2;
        public int AP => 2;
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