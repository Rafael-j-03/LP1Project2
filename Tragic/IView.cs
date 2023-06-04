using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public interface IView
    {
        public void ShowPlayersCards(Player player1, Player player2);
    }
}