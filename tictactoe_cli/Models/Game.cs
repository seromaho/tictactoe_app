using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoe_cli.Models
{
    class Game : IGame
    {
        public string[] A1 { get; set; }
        public string[] B1 { get; set; }
        public string[] C1 { get; set; }
        public string[] A2 { get; set; }
        public string[] B2 { get; set; }
        public string[] C2 { get; set; }
        public string[] A3 { get; set; }
        public string[] B3 { get; set; }
        public string[] C3 { get; set; }
        public bool GameIsOver { get; set; }
        public IPlayer player_1 { get; set; }
        public IPlayer player_2 { get; set; }

        public Game()
        {
            A1 = new string[3] { " ", "15", "6" };
            B1 = new string[3] { " ", "25", "6" };
            C1 = new string[3] { " ", "35", "6" };
            A2 = new string[3] { " ", "15", "10" };
            B2 = new string[3] { " ", "25", "10" };
            C2 = new string[3] { " ", "35", "10" };
            A3 = new string[3] { " ", "15", "14" };
            B3 = new string[3] { " ", "25", "14" };
            C3 = new string[3] { " ", "35", "14" };
            GameIsOver = false;
            player_1 = new Player();
            player_2 = new Player();
        }

        public void DisplayGameStatus()
        {
            Console.Clear();

            Console.WriteLine("- - - Tic Tac Toe - - -\n\n");
            int initialLeft = Console.CursorLeft;
            int initialTop = Console.CursorTop;

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

            //int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;

            Console.SetCursorPosition(initialLeft + Convert.ToInt32(A1[1]), initialTop + Convert.ToInt32(A1[2]));
            Console.Write(A1[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(A2[1]), initialTop + Convert.ToInt32(A2[2]));
            Console.Write(A2[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(A3[1]), initialTop + Convert.ToInt32(A3[2]));
            Console.Write(A3[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(B1[1]), initialTop + Convert.ToInt32(B1[2]));
            Console.Write(B1[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(B2[1]), initialTop + Convert.ToInt32(B2[2]));
            Console.Write(B2[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(B3[1]), initialTop + Convert.ToInt32(B3[2]));
            Console.Write(B3[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(C1[1]), initialTop + Convert.ToInt32(C1[2]));
            Console.Write(C1[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(C2[1]), initialTop + Convert.ToInt32(C2[2]));
            Console.Write(C2[0]);
            Console.SetCursorPosition(initialLeft + Convert.ToInt32(C3[1]), initialTop + Convert.ToInt32(C3[2]));
            Console.Write(C3[0]);

            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, currentTop + 1);

            Play(player_1);
        }

        public string Play(IPlayer player)
        {
            Console.CursorVisible = true;

            Console.WriteLine("- - - PLAYER {0} - - -", player.Name);
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
                    A1[0] = player.Symbol;
                    break;

                case "A2":
                case "a2":
                case "2A":
                case "2a":
                    A2[0] = player.Symbol;
                    break;

                case "A3":
                case "a3":
                case "3A":
                case "3a":
                    A3[0] = player.Symbol;
                    break;

                case "B1":
                case "b1":
                case "1B":
                case "1b":
                    B1[0] = player.Symbol;
                    break;

                case "B2":
                case "b2":
                case "2B":
                case "2b":
                    B2[0] = player.Symbol;
                    break;

                case "B3":
                case "b3":
                case "3B":
                case "3b":
                    B3[0] = player.Symbol;
                    break;

                case "C1":
                case "c1":
                case "1C":
                case "1c":
                    C1[0] = player.Symbol;
                    break;

                case "C2":
                case "c2":
                case "2C":
                case "2c":
                    C2[0] = player.Symbol;
                    break;

                case "C3":
                case "c3":
                case "3C":
                case "3c":
                    C3[0] = player.Symbol;
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

        public bool GameIsDraw()
        {
            throw new NotImplementedException();
        }

        public bool GameIsWon()
        {
            throw new NotImplementedException();
        }
    }
}
