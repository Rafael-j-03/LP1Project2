using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class LobsterMcCrabs : ICard
    {
        public string Name => "Lobster McCrabs";
        public int C => 2;
        public int AP => 1;
        public int DP => 3;
        public int Quantity => 2;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}