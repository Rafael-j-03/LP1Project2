using System;

namespace Tragic
{
    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        private static void Main()
        {
            // Create two players with decks
            Player player1 = new Player("1", 10, 0, new Deck());
            Player player2 = new Player("2", 10, 0, new Deck());

            // Create a controller with two players
            Controller controller = new Controller(player1, player2);

            // Create a view with a controller
            IView view = new View(controller);

            // Start the game
            controller.Run(view);
        }
    }
}
