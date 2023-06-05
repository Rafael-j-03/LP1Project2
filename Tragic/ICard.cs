using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public interface ICard
    {
        public string Name { get; }
        public int C { get; }
        public int AP { get; }
        public int DP { get; set; }
        public int Quantity { get; }
    }
}