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

        public void ShowPlayerCards(Player player)
        {
            Console.WriteLine($"Player {player.PlayerNumber}");
            Console.WriteLine($"HP: {player.HP}");
            Console.WriteLine($"MP: {player.MP}");

            Console.WriteLine("Choose a card to play by entering its index:");
            for (int i = 0; i < player.Hand.GetCards().Count; i++)
            {
                ICard card = player.Hand.GetCards()[i];
                Console.WriteLine($"{i + 1}. {card}");
            }
            Console.WriteLine("\nEnter '0' to skip your turn.");
        }

        public void InvalidChoice()
        {
            Console.WriteLine("\nInvalid choice. Press any key to continue...");
            // Press any key to continue...
            Console.ReadKey();

            ClearScreen();
        }

        public void CardCost(ICard selectedCard, Player player)
        {
            Console.WriteLine($"\nYou have played {selectedCard.Name}" + 
                              $"(MP Cost: {selectedCard.C})");
            if (player.MP > 0)
            {
                Console.WriteLine($"You have {player.MP} MP remaining.");
            }

            // Press any key to continue...
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            ClearScreen();
        }

        public void NoMPForCard(ICard selectedCard)
        {
            Console.WriteLine($"\nYou played no MP for {selectedCard.Name}!");

            // Press any key to continue...
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            ClearScreen();
        }

        public void NoMP(Player player)
        {
            ClearScreen();

            Console.WriteLine($"You have no MP remaining. Your Spell Phase ends.");

            // Press any key to continue...
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            ClearScreen();
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}