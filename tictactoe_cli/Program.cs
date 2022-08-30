using Extensions;
using System;
using tictactoe_cli.Models;

namespace tictactoe_cli
{
    class Program
    {
        static void Main()
        {
            // Save the console window width before modifying it
            // Save the console window height before modifying it
            Tuple<int, int> originalWindowSize = new Tuple<int, int>(Console.WindowWidth, Console.WindowHeight);

            // Save the screen buffer area width before modifying it
            int originalBufferWidth = Console.BufferWidth;

            // Set the console window width to fit the application
            // Set the console window height to fit the screen
            // Set the screen buffer area width to fit the application
            Console_Extensions.FitWindowAndBufferSize();

            Game ticTacToe = new Game();

            while (true)
            {
                // START OF (REMATCH || NEW GAME) LOOP //////////////////////

                while (true)
                {
                    // START OF GAMEPLAY LOOP //////////////////////

                    ticTacToe.DisplayGameStatus(ticTacToe.Player_2);

                    if (ticTacToe.GameIsOver)
                    {
                        break;
                    }

                    ticTacToe.TakeAction(ticTacToe.Player_1);

                    ticTacToe.DisplayGameStatus(ticTacToe.Player_1);

                    if (ticTacToe.GameIsOver)
                    {
                        break;
                    }

                    ticTacToe.TakeAction(ticTacToe.Player_2);

                    // END OF GAMEPLAY LOOP //////////////////////
                }

                // Ask the players to have a rematch against each other
                // Ask the players to create a new game w/ new players
                ticTacToe.DisplayGameStatus();
                Console.CursorVisible = true;
                Console.Write("\nTo play a rematch, type 're' or 'rematch':");
                Console.Write("\nTo play a new game (w/ new players), type 'n' or 'new':\n");
                string gameLoop = Console.ReadLine();

                switch (gameLoop)
                {
                    case "r":
                    case "re":
                    case "rematch":
                        // Clear the playing field for a rematch
                        ticTacToe.ResetGameBoard();
                        continue;
                    case "n":
                    case "new":
                        // Create a new game w/ new players
                        ticTacToe = new Game();
                        continue;
                    default:
                        Console.Clear();
                        // Revert the changes made to console window width and console window height
                        // Revert the changes made to the screen buffer area width
                        Console_Extensions.RestoreWindowAndBufferSize(originalWindowSize, originalBufferWidth);
                        return;
                }

                // END OF (REMATCH || NEW GAME) LOOP //////////////////////
            }
        }
    }
}
