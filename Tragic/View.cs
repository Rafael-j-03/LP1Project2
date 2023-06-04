using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public class View : IView
    {
        private readonly Controller controller;

        public View(Controller controller)
        {
            this.controller = controller;
        }

        public void ShowPlayersCards(Player player1, Player player2)
        {
            foreach (ICard card in player1.Hand.GetCards())
            {
                Console.WriteLine("Player 1: " + card);
            }

            foreach (ICard card in player2.Hand.GetCards())
            {
                Console.WriteLine("Player 2: " + card);
            }
        }
    }
}