using Extensions;
using System;
using tictactoe_cli.Models;

namespace tictactoe_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console_Extensions.FitWindowAndBufferSize();

            Game ticTacToe = new Game();

            while (true)
            {
                // START OF REMATCH LOOP //////////////////////

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
                ticTacToe.DisplayGameStatus();
                Console.CursorVisible = true;
                Console.Write("\nTo have a rematch type 'y' or 'yes':\t");
                string reMatch = Console.ReadLine();

                if (!reMatch.ToLower().Equals("y") && !reMatch.ToLower().Equals("yes"))
                {
                    break;
                }
                else
                {
                    // Clear the playing field for a rematch
                    ticTacToe.ResetGameBoard();
                }

                // END OF REMATCH LOOP //////////////////////
            }
        }
    }
}
