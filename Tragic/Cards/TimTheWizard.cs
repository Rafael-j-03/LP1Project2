using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Tim, The Wizard card
    /// </summary>
    public class TimTheWizard : ICard
    {
        public string Name => "Tim, The Wizard";
        public int C => 5;
        public int AP => 6;
        public int DP { get; set; } = 4;
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