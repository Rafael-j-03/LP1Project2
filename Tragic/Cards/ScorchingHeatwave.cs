using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Scorching Heatwave card
    /// </summary>
    public class ScorchingHeatwave : ICard
    {
        public string Name => "Scorching Heatwave";
        public int C => 4;
        public int AP => 5;
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