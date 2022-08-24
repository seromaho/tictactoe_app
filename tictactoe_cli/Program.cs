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
            //Console.Write(Console.CursorLeft);
            //Console.Write(Console.CursorTop);
            //Console.ReadKey();

            //Console.WriteLine(Directory.GetCurrentDirectory());
            //foreach (string item in Directory.GetDirectories(Directory.GetCurrentDirectory()))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName);
            //Console.WriteLine(Path.Combine("..", "..", "..", "Data", "name.txt"));

            //foreach (var image in Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images")))
            //{
            //    Console.WriteLine(image);
            //}

            Game ticTacToe = new Game();

            while (!ticTacToe.GameIsOver)
            {
                ticTacToe.DisplayGameStatus();

                ticTacToe.TakeAction(ticTacToe.player_1);

                if (ticTacToe.GameIsOver)
                {
                    break;
                }

                ticTacToe.DisplayGameStatus();

                ticTacToe.TakeAction(ticTacToe.player_2);
            }
        }
    }
}
