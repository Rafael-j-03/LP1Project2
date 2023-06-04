using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class ScorchingHeatwave : ICard
    {
        public string Name => "Scorching Heatwave";
        public int C => 4;
        public int AP => 5;
        public int DP => 3;
        public int Quantity => 1;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}