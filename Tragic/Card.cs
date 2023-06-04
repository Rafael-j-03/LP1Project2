using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public interface Card
    {
        public string Name { get; }
        public int C { get; }
        public int AP { get; }
        public int DP { get; }
        public int Quantity { get; }
    }
}