using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    public interface IView
    {
        public void ShowPlayerCards(Player player, string playerNumber);
        public void InvalidChoice();
        public void CardCost(ICard selectedCard, Player player);
        public void NoMPForCard(ICard selectedCard);
        public void NoMP(Player player);
        public void ClearScreen();
    }
}