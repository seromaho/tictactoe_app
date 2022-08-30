using Extensions;
using System;

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
        public IPlayer Player_1 { get; set; }
        public IPlayer Player_2 { get; set; }

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
            Player_1 = new Player();
            Player_2 = new Player();
        }

        public void DisplayGameBoard()
        {
            Console.CursorVisible = false;

            // Draw the empty playing field
            Console.WriteLine("          +---------+---------+---------+");
            Console.WriteLine("          |         |         |         |");
            Console.WriteLine("          |    A    |    B    |    C    |");
            Console.WriteLine("          |         |         |         |");
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
            Console.WriteLine("          |         |         |         |");
            Console.WriteLine("          |    A    |    B    |    C    |");
            Console.WriteLine("          |         |         |         |");
            Console.WriteLine("          +---------+---------+---------+");
        }

        public void DisplayGameStatus()
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.WriteLine("- - - Tic Tac Toe - - -\n\n");
            DisplayPlayerScore(Player_1, Player_2);

            // Save cursor position before drawing the playing field
            int initialLeft = Console.CursorLeft;
            int initialTop = Console.CursorTop;

            // Draw the empty playing field
            DisplayGameBoard();

            // Save cursor top position after drawing the playing field
            int currentTop = Console.CursorTop;

            // Place both player's symbols onto the playing field as required
            // Use cursor position "before drawing the playing field" as reference
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

            // Return to cursor position "after drawing the playing field"
            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, currentTop + 1);
        }

        public void DisplayGameStatus(IPlayer player)
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.WriteLine("- - - Tic Tac Toe - - -\n\n");
            DisplayPlayerScore(Player_1, Player_2);

            // Save cursor position before drawing the playing field
            int initialLeft = Console.CursorLeft;
            int initialTop = Console.CursorTop;

            // Draw the empty playing field
            DisplayGameBoard();

            // Save cursor top position after drawing the playing field
            int currentTop = Console.CursorTop;

            // Place both player's symbols onto the playing field as required
            // Use cursor position "before drawing the playing field" as reference
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

            // Return to cursor position "after drawing the playing field"
            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, currentTop + 1);

            CheckIfGameIsOver(player);
        }

        public void DisplayPlayerScore(IPlayer player_1, IPlayer player_2)
        {
            Console.Write("Number of games won:\t");
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.WriteLine("{0}  - {1,2}", player_1.Name, player_1.NumGamesWon);
            Console.SetCursorPosition(cursorLeft, cursorTop + 1);
            Console.WriteLine("{0}  - {1,2}", player_2.Name, player_2.NumGamesWon);
            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop + 1);
        }

        public void ResetGameBoard()
        {
            GameIsOver = false;

            A1[0] = " ";
            B1[0] = " ";
            C1[0] = " ";
            A2[0] = " ";
            B2[0] = " ";
            C2[0] = " ";
            A3[0] = " ";
            B3[0] = " ";
            C3[0] = " ";

            SwapPlayerLineUp();
        }

        public void SwapPlayerLineUp()
        {
            // Switch around players to alternate their starting position in case of a rematch
            IPlayer playerSwap = Player_2;
            Player_2 = Player_1;
            Player_1 = playerSwap;
        }

        public void TakeAction(IPlayer player)
        {
            Console.CursorVisible = true;

            // Display an image of current player's symbol
            player.Avatar.ToAsciiArtwork();

            while (true)
            {
                Console.WriteLine("- - - PLAYER {0} - - -", player.Name);
                Console.WriteLine("Pick a field to place your symbol by typing the field's coordinate.");
                Console.WriteLine("(for example, type: {0})", ReturnRandomField());
                Console.Write("Field:\t");
                string fieldName = Console.ReadLine();

                // Check if player's input is a valid playing field name
                // Check if the chosen playing field is still empty and available
                // Place player's symbol on the chosen playing field if both checks return true
                // Restart the input process if any check returns false
                switch (fieldName)
                {
                    case "A1":
                    case "a1":
                    case "1A":
                    case "1a":
                        if (string.IsNullOrWhiteSpace(A1[0]))
                        {
                            A1[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "A2":
                    case "a2":
                    case "2A":
                    case "2a":
                        if (string.IsNullOrWhiteSpace(A2[0]))
                        {
                            A2[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "A3":
                    case "a3":
                    case "3A":
                    case "3a":
                        if (string.IsNullOrWhiteSpace(A3[0]))
                        {
                            A3[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "B1":
                    case "b1":
                    case "1B":
                    case "1b":
                        if (string.IsNullOrWhiteSpace(B1[0]))
                        {
                            B1[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "B2":
                    case "b2":
                    case "2B":
                    case "2b":
                        if (string.IsNullOrWhiteSpace(B2[0]))
                        {
                            B2[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "B3":
                    case "b3":
                    case "3B":
                    case "3b":
                        if (string.IsNullOrWhiteSpace(B3[0]))
                        {
                            B3[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "C1":
                    case "c1":
                    case "1C":
                    case "1c":
                        if (string.IsNullOrWhiteSpace(C1[0]))
                        {
                            C1[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "C2":
                    case "c2":
                    case "2C":
                    case "2c":
                        if (string.IsNullOrWhiteSpace(C2[0]))
                        {
                            C2[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    case "C3":
                    case "c3":
                    case "3C":
                    case "3c":
                        if (string.IsNullOrWhiteSpace(C3[0]))
                        {
                            C3[0] = player.Symbol;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("field is already claimed - try again\n");
                            break;
                        }

                    default:
                        Console.WriteLine("invalid input - try again\n");
                        break;
                }
            }
        }

        public string ReturnRandomField()
        {
            Random RNG = new Random();
            string[] fields = new string[9] { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3" };
            string field = fields[RNG.Next(fields.Length)];

            switch (field)
            {
                case "A1":
                    if (string.IsNullOrWhiteSpace(A1[0])) { return field; } return ReturnRandomField();
                case "A2":
                    if (string.IsNullOrWhiteSpace(A2[0])) { return field; } return ReturnRandomField();
                case "A3":
                    if (string.IsNullOrWhiteSpace(A3[0])) { return field; } return ReturnRandomField();
                case "B1":
                    if (string.IsNullOrWhiteSpace(B1[0])) { return field; } return ReturnRandomField();
                case "B2":
                    if (string.IsNullOrWhiteSpace(B2[0])) { return field; } return ReturnRandomField();
                case "B3":
                    if (string.IsNullOrWhiteSpace(B3[0])) { return field; } return ReturnRandomField();
                case "C1":
                    if (string.IsNullOrWhiteSpace(C1[0])) { return field; } return ReturnRandomField();
                case "C2":
                    if (string.IsNullOrWhiteSpace(C2[0])) { return field; } return ReturnRandomField();
                case "C3":
                    if (string.IsNullOrWhiteSpace(C3[0])) { return field; } return ReturnRandomField();

                default:
                    return ReturnRandomField();
            }
        }

        public bool CheckIfGameIsDraw()
        {
            Console.CursorVisible = false;

            // Check if any game board fields are empty
            // End the game if there aren't any empty game board fields
            if (!string.IsNullOrWhiteSpace(A1[0]) && !string.IsNullOrWhiteSpace(A2[0]) && !string.IsNullOrWhiteSpace(A3[0]) && !string.IsNullOrWhiteSpace(B1[0]) && !string.IsNullOrWhiteSpace(B2[0]) && !string.IsNullOrWhiteSpace(B3[0]) && !string.IsNullOrWhiteSpace(C1[0]) && !string.IsNullOrWhiteSpace(C2[0]) && !string.IsNullOrWhiteSpace(C3[0]))
            {
                //GameIsOver = true;

                Console.WriteLine("\nGame is over:\tDRAW");
                Console.ReadKey();
                return true;
            }

            // Define the vertical lines of the playing field
            string verticalLine_A = A1[0] + A2[0] + A3[0];
            string verticalLine_B = B1[0] + B2[0] + B3[0];
            string verticalLine_C = C1[0] + C2[0] + C3[0];
            // Define the horizontal lines of the playing field
            string horizontalLine_1 = A1[0] + B1[0] + C1[0];
            string horizontalLine_2 = A2[0] + B2[0] + C2[0];
            string horizontalLine_3 = A3[0] + B3[0] + C3[0];
            // Define the diagonal lines of the playing field
            string crossLineLeft = A1[0] + B2[0] + C3[0];
            string crossLineRight = C1[0] + B2[0] + A3[0];
            // Define the triple lines of both players
            string tripleLine_1 = Player_1.Symbol + Player_1.Symbol + Player_1.Symbol;
            string tripleLine_2 = Player_2.Symbol + Player_2.Symbol + Player_2.Symbol;

            // Check if any line of playing fields could potentially become a triple line (not taking player turns into account)
            // End the game if no line of playing fields could potentially become a triple line
            if (
                !verticalLine_A.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !verticalLine_A.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&
                !verticalLine_B.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !verticalLine_B.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&
                !verticalLine_C.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !verticalLine_C.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&

                !horizontalLine_1.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !horizontalLine_1.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&
                !horizontalLine_2.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !horizontalLine_2.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&
                !horizontalLine_3.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !horizontalLine_3.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&

                !crossLineLeft.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !crossLineLeft.Replace(" ", Player_2.Symbol).Equals(tripleLine_2) &&
                !crossLineRight.Replace(" ", Player_1.Symbol).Equals(tripleLine_1) && !crossLineRight.Replace(" ", Player_2.Symbol).Equals(tripleLine_2)
               )
            {
                //GameIsOver = true;

                Console.WriteLine("\nGame is over:\tDRAW");
                Console.ReadKey();
                return true;
            }

            return false;
        }

        public bool CheckIfGameIsWon(IPlayer player)
        {
            Console.CursorVisible = false;

            // Define the vertical lines of the playing field
            string verticalLine_A = A1[0] + A2[0] + A3[0];
            string verticalLine_B = B1[0] + B2[0] + B3[0];
            string verticalLine_C = C1[0] + C2[0] + C3[0];
            // Define the horizontal lines of the playing field
            string horizontalLine_1 = A1[0] + B1[0] + C1[0];
            string horizontalLine_2 = A2[0] + B2[0] + C2[0];
            string horizontalLine_3 = A3[0] + B3[0] + C3[0];
            // Define the diagonal lines of the playing field
            string crossLineLeft = A1[0] + B2[0] + C3[0];
            string crossLineRight = C1[0] + B2[0] + A3[0];
            // Define the triple line of the current player
            string tripleLine = player.Symbol + player.Symbol + player.Symbol;

            // Check if any vertical line of playing fields is a triple line of the current player's symbol
            // End the game if check returns true
            if (verticalLine_A.Equals(tripleLine) || verticalLine_B.Equals(tripleLine) || verticalLine_C.Equals(tripleLine))
            {
                //GameIsOver = true;
                player.NumGamesWon++;

                Console.WriteLine("\nGame is over:\tWINNER IS PLAYER {0} !", player.Name.ToUpper());
                Console.ReadKey();
                return true;
            }

            // Check if any horizontal line of playing fields is a triple line of the current player's symbol
            // End the game if check returns true
            if (horizontalLine_1.Equals(tripleLine) || horizontalLine_2.Equals(tripleLine) || horizontalLine_3.Equals(tripleLine))
            {
                //GameIsOver = true;
                player.NumGamesWon++;

                Console.WriteLine("\nGame is over:\tWINNER IS PLAYER {0} !", player.Name.ToUpper());
                Console.ReadKey();
                return true;
            }

            // Check if any diagonal line of playing fields is a triple line of the current player's symbol
            // End the game if check returns true
            if (crossLineLeft.Equals(tripleLine) || crossLineRight.Equals(tripleLine))
            {
                //GameIsOver = true;
                player.NumGamesWon++;

                Console.WriteLine("\nGame is over:\tWINNER IS PLAYER {0} !", player.Name.ToUpper());
                Console.ReadKey();
                return true;
            }

            return false;
        }

        public void CheckIfGameIsOver(IPlayer player)
        {
            Console.CursorVisible = false;

            if (CheckIfGameIsWon(player))
            {
                GameIsOver = true;
            }
            else if (CheckIfGameIsDraw())
            {
                GameIsOver = true;
            }
        }
    }
}
