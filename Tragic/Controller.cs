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
        private IView view;

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

                SpellPhase(player1, view, "1");
                SpellPhase(player2, view, "2");
                CombatPhase(player1, player2, view);
            }
        }

        public void SpellPhase(Player player, IView view, string playerNumber)
        {
            while (player.MP > 0)
            {
                // Player chooses a card to play
                ICard selectedCard = ChooseCardToPlay(player, view, playerNumber);

                // Check if the selected card is valid and the player has enough MP to play it
                if (selectedCard != null && selectedCard.C <= player.MP)
                {
                    // Play the selected card
                    player.MP -= selectedCard.C;
                    player.Hand.RemoveCard(selectedCard);
                    // Display the cost of the selected card
                    view.CardCost(selectedCard, player);

                    // Continue playing if the player has remaining MP
                    if (player.MP > 0)
                    {
                        // Prompt the player to continue playing
                        bool continuePlaying = PromptContinuePlaying(player, view);

                        if (continuePlaying)
                        {
                            continue;
                        }
                    }
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
            view.NoMP(player);
        }

        private ICard ChooseCardToPlay(Player player, IView view, string playerNumber)
        {
            view.ShowPlayerCards(player, playerNumber);

            int cardIndex;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out cardIndex) && 
                    cardIndex >= 1 && cardIndex <= player.Hand.GetCards().Count)
                {
                    return player.Hand.GetCards()[cardIndex - 1];
                }
                else
                {
                    view.InvalidChoice();
                    SpellPhase(player, view, playerNumber);
                }
            }
        }

        private bool PromptContinuePlaying(Player player, IView view)
        {
            view.ContinuePlaying();

            while (true)
            {
                if (view.ContinuePlaying() == "Y")
                {
                    return true;
                }
                else if (view.ContinuePlaying() == "N")
                {
                    return false;
                }
                else
                {
                    view.InvalidChoice();
                }
            }
        }


        public void CombatPhase(Player player1, Player player2, IView view)
        {
            
        }
    }
}