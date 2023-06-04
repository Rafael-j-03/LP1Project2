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
        private int round = 0;

        public Controller(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public Player GetPlayer1()
        {
            return player1;
        }

        public Player GetPlayer2()
        {
            return player2;
        }

        public void Run(IView view)
        {
            while (player1.HP > 0 || player2.HP > 0)
            {
                view.ShowPlayersCards(player1, player2);
                Round(player1, player2);
            }
        }

        public void Round(Player player1, Player player2)
        {
            SpellPhase();
            CombatPhase();
            round++;

            // Add MP to the players 1 for 1 round 2 for 2 rounds etc.
            if (round <= 4)
            {
                player1.MP = round;
                player2.MP = round;
            }
            else if (round >= 5)
            {
                player1.MP = 5;
                player2.MP = 5;
            }
        }

        public void SpellPhase()
        {

        }

        public void CombatPhase()
        {

        }
    }
}