using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class TimTheWizard : ICard
    {
        public string Name => "Tim, The Wizard";
        public int C => 5;
        public int AP => 6;
        public int DP => 4;
        public int Quantity => 1;

        // Override ToString() to display the card's Name/C/AP/DP
        public override string ToString()
        {
            return $"{Name}/{C}/{AP}/{DP}";
        }
    }
}