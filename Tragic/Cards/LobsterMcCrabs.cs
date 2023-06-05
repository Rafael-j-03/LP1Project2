using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Lobster McCrabs card
    /// </summary>
    public class LobsterMcCrabs : ICard
    {
        public string Name => "Lobster McCrabs";
        public int C => 2;
        public int AP => 1;
        public int DP { get; set;} = 3;
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