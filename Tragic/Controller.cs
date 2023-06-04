using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class Controller
    {
        private Player player1;
        private Player player2;

        public Controller(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
    }
}