using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe_cli.Models
{
    class Game : IGame
    {
        public string A1 { get; set; }
        public string B1 { get; set; }
        public string C1 { get; set; }
        public string A2 { get; set; }
        public string B2 { get; set; }
        public string C2 { get; set; }
        public string A3 { get; set; }
        public string B3 { get; set; }
        public string C3 { get; set; }
        public IPlayer player_1 { get; set; }
        public IPlayer player_2 { get; set; }

        public Game()
        {
            player_1 = new Player();
            player_2 = new Player();
            DisplayGameStatus();
        }

        public void DisplayGameStatus()
        {
            Console.Clear();

            Console.WriteLine("Tic Tac Toe\n\n");
            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            Console.WriteLine("+---------+---------+---------+---------+---------+");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("|         |    A    |    B    |    C    |         |");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("+---------+---------+---------+---------+---------+");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("|    1    |         |         |         |    1    |");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("+---------+---------+---------+---------+---------+");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("|    2    |         |         |         |    2    |");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("+---------+---------+---------+---------+---------+");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("|    3    |         |         |         |    3    |");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("+---------+---------+---------+---------+---------+");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("|         |    A    |    B    |    C    |         |");
            Console.WriteLine("|         |         |         |         |         |");
            Console.WriteLine("+---------+---------+---------+---------+---------+");

            Play(player_1);
        }

        public string Play(IPlayer player)
        {
            Console.CursorVisible = true;

            Console.WriteLine("\n- - - PLAYER {0} - - -", player.Name);
            Console.WriteLine("Pick a field to place your symbol by typing the field's coordinate.");
            Console.WriteLine("(for example, type: A1)");
            Console.Write("Field:\t");
            string fieldName = Console.ReadLine();

            switch (fieldName)
            {
                case "A1":
                case "a1":
                case "1A":
                case "1a":
                    A1 = player.Symbol;
                    break;

                case "A2":
                case "a2":
                case "2A":
                case "2a":
                    A2 = player.Symbol;
                    break;

                case "A3":
                case "a3":
                case "3A":
                case "3a":
                    A3 = player.Symbol;
                    break;

                case "B1":
                case "b1":
                case "1B":
                case "1b":
                    B1 = player.Symbol;
                    break;

                case "B2":
                case "b2":
                case "2B":
                case "2b":
                    B2 = player.Symbol;
                    break;

                case "B3":
                case "b3":
                case "3B":
                case "3b":
                    B3 = player.Symbol;
                    break;

                case "C1":
                case "c1":
                case "1C":
                case "1c":
                    C1 = player.Symbol;
                    break;

                case "C2":
                case "c2":
                case "2C":
                case "2c":
                    C2 = player.Symbol;
                    break;

                case "C3":
                case "c3":
                case "3C":
                case "3c":
                    C3 = player.Symbol;
                    break;

                default:
                    Console.WriteLine("ungültige Eingabe");
                    break;
            }

            return fieldName;
        }

        public void WriteGameLog()
        {
            throw new NotImplementedException();
        }
    }
}
