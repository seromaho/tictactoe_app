using Extensions;
using System;
using System.IO;
using tictactoe_cli.Models;

namespace tictactoe_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Game ticTacToe = new Game();

            while (true)
            {
                ticTacToe.DisplayGameStatus(ticTacToe.player_2);

                if (ticTacToe.GameIsOver)
                {
                    break;
                }

                ticTacToe.TakeAction(ticTacToe.player_1);

                ticTacToe.DisplayGameStatus(ticTacToe.player_1);

                if (ticTacToe.GameIsOver)
                {
                    break;
                }

                ticTacToe.TakeAction(ticTacToe.player_2);
            }
        }
    }
}
