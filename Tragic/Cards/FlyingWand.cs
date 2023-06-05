using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Flying Wand card
    /// </summary>
    public class FlyingWand : ICard
    {
        public string Name => "Flying Wand";
        public int C => 1;
        public int AP => 1;
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