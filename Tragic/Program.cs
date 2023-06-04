using System;

namespace Tragic
{
    public class Program
    {
        private static void Main()
        {
            // Create two players
            new Player(20, 0, new List<Card> { new Card(1, 1, 1) });
            new Player(20, 0, new List<Card> { new Card(1, 1, 1) });

            // Create a controller with two players
            Controller controller = new Controller(player1, player2);

            // Create a view with a controller
            IView view = new View(controller);

            // Start the game
            controller.Run();
        }
    }
}
