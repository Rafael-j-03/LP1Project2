using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Interface for the view
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Show the player's cards
        /// </summary>
        /// <param name="player">Selected player</param>
        public void ShowPlayerCards(Player player);

        /// <summary>
        /// Show the player's selected cards
        /// </summary>
        public void InvalidChoice();

        /// <summary>
        /// Show the player's selected cards
        /// </summary>
        /// <param name="selectedCard">Selected card</param>
        /// <param name="player">Selected player</param>
        public void CardCost(ICard selectedCard, Player player);

        /// <summary>
        /// Message if the player has no MP for the card
        /// </summary>
        /// <param name="selectedCard">Selected card</param>
        public void NoMPForCard(ICard selectedCard);

        /// <summary>
        /// Message if the player has no MP
        /// </summary>
        /// <param name="player">Selected player</param>
        public void NoMP(Player player);
        
        /// <summary>
        /// Clear the screen from the console
        /// </summary>
        public void ClearScreen();
    }
}