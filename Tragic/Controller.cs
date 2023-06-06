using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tragic
{
    /// <summary>
    /// Controller for the game
    /// </summary>
    public class Controller
    {   
        private Player player1;
        private Player player2;
        private IView view;

        /// <summary>
        /// Constructor for the controller
        /// </summary>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        public Controller(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        /// <summary>
        /// Run the game
        /// </summary>
        /// <param name="view">View from the project</param>
        public void Run(IView view)
        {
            this.view = view;
            int round = 0;

            view.ClearScreen();
            while (player1.HP > 0 || player2.HP > 0)
            {
                round++;
                // if cards in deck are more than 0, draw cards
                if (player1.Deck.GetCards().Count > 0)
                    player1.Hand.DrawCard();

                if (player2.Deck.GetCards().Count > 0)
                    player2.Hand.DrawCard();

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

                SpellPhase(player1, view);
                SpellPhase(player2, view);
                //CombatPhase(player1, player2, view);
            }
        }

        /// <summary>
        /// Spell phase
        /// </summary>
        /// <param name="player">Current player playing</param>
        /// <param name="view">View from the project</param>
        public void SpellPhase(Player player, IView view)
        {
            while (player.MP > 0)
            {
                // Player chooses a card to play
                ICard selectedCard = ChooseCardToPlay(player, view);

                // If the player chooses to skip their turn, break out of the loop
                if (selectedCard == null)
                    break;

                // Check if the selected card is valid and the player has enough MP to play it
                if (selectedCard != null && selectedCard.C <= player.MP)
                {
                    // Play the selected card
                    player.MP -= selectedCard.C;
                    player.Hand.RemoveCard(selectedCard);
                    player.SelectedCards.AddCard(selectedCard);
                    // Display the cost of the selected card
                    view.CardCost(selectedCard, player);
                }
                else if (selectedCard.C > player.MP)
                {
                    view.NoMPForCard(selectedCard);
                }
                else
                {
                    view.InvalidChoice();
                }
            }

            if (player.MP == 0)
                view.NoMP(player);
        }

        /// <summary>
        /// Player chooses a card to play
        /// </summary>
        /// <param name="player">Current player playing</param>
        /// <param name="view">View from the project</param>
        /// <returns></returns>
        private ICard ChooseCardToPlay(Player player, IView view)
        {
            view.ShowPlayerCards(player);

            string input = Console.ReadLine();

            if (input == "0")
            {
                view.ClearScreen();
                return null;
            }
            else if (int.TryParse(input, out int cardIndex) &&
                cardIndex >= 1 && cardIndex <= player.Hand.GetCards().Count)
            {
                return player.Hand.GetCards()[cardIndex - 1];
            }
            else
            {
                view.InvalidChoice();
                return ChooseCardToPlay(player, view);
            }
        }
        
        /// <summary>
        /// Combat phase
        /// </summary>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        /// <param name="view">View from the project</param>
        public void CombatPhase(Player player1, Player player2, IView view)
        {
            List<ICard> player1Cards = player1.SelectedCards.GetCards();
            List<ICard> player2Cards = player2.SelectedCards.GetCards();

            while (player1Cards.Count > 0 && player2Cards.Count > 0)
            {
                int modifiedDP = player2Cards[0].DP - player1Cards[0].AP;
        
                // Create a new card of the same type with the modified DP value
                ICard modifiedCard = (ICard)Activator.CreateInstance(player2Cards[0].GetType());
                modifiedCard.DP = modifiedDP;

                // TODO: Implement the combat phase and display the results
            }
        }
    }
}