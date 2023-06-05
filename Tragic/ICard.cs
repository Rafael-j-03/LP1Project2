using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Interface for the cards
    /// </summary>
    public interface ICard
    {
        /// <summary>
        /// Card name
        /// </summary>
        /// <value></value>
        public string Name { get; }

        /// <summary>
        /// Card cost
        /// </summary>
        /// <value></value>
        public int C { get; }

        /// <summary>
        /// Card attack points
        /// </summary>
        /// <value></value>
        public int AP { get; }

        /// <summary>
        /// Card defense points
        /// </summary>
        /// <value></value>
        public int DP { get; set; }

        /// <summary>
        /// Card quantity available
        /// </summary>
        /// <value></value>
        public int Quantity { get; }
    }
}