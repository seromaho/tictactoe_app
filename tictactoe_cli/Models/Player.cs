using Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace tictactoe_cli.Models
{
    class Player : IPlayer
    {
        private static int _playerCounter = 0;
        private static string _playerNameCheck;
        public string Name { get; set; }
        public string Symbol { get; set; }
        public Bitmap Avatar { get; set; }
        public int NumGamesWon { get; set; }

        public Player()
        {
            _playerCounter++;
            Name = NameFromInput();
            Symbol = SymbolFromList();
            Avatar = AvatarFromList();
            NumGamesWon = 0;

            Console_Extensions.LoadingBar();
        }

        private static string NameFromInput()
        {
            Console.Clear();
            string input;

            while (true)
            {
                // Let the current player enter their name
                Console.CursorVisible = true;
                Console.WriteLine("- - - PLAYER {0} - - -", _playerCounter);
                Console.WriteLine("Enter your name or leave empty to get a random name:");
                input = Console.ReadLine();

                // Assign a random name if none was entered
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                {
                    input = NameFromList();
                }

                // Check input string's length
                // Reject input if it has too many chars to fit the playing field display
                if (input.Length > 27)
                {
                    Console.WriteLine("name is too long - try again\n");
                    continue;
                }

                // Check if input string equals the first player's name
                // Reject input if true
                if (_playerCounter % 2 == 0)
                {
                    if (input.Equals(_playerNameCheck))
                    {
                        Console.WriteLine("name is already taken - try again\n");
                        continue;
                    }
                }
                else
                {
                    _playerNameCheck = input;
                }

                Console.CursorVisible = false;
                Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop - 1);
                Console.WriteLine("Your name is: {0}.", input);

                return input;
            }
        }

        private static string NameFromList()
        {
            Console.CursorVisible = false;

            // relative path from solution (tictactoe_app)
            string solutionPath = Path.Combine("tictactoe_cli", "Data", "names.txt");
            // relative path from project (tictactoe_cli)
            string projectPath = Path.Combine("Data", "names.txt");
            // DEFAULT Current Directory in DEBUG: '${HOME}\Source\Repos\seromaho\tictactoe_app\tictactoe_cli\bin\Debug\netcoreapp3.1'
            string debugPath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "names.txt");
            // DEFAULT Current Directory in RELEASE: '${HOME}\source\repos\seromaho\tictactoe_app\tictactoe_cli\bin\Release\netcoreapp3.1\publish'
            string releasePath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName, "Data", "names.txt");

            // Get a random name from "tictactoe_app\tictactoe_cli\Data\names.txt" and make its first letter upper case
            string nameListStorage;
            if (File.Exists(solutionPath)) { nameListStorage = solutionPath; }
            else if (File.Exists(projectPath)) { nameListStorage = projectPath; }
            else if (File.Exists(releasePath)) { nameListStorage = releasePath; }
            else if (File.Exists(debugPath)) { nameListStorage = debugPath; }
            else
            {
                nameListStorage = string.Empty;
                return NameFromSource();
            }

            List<string> nameList = new List<string>();

            FileStream fileStream = new FileStream(nameListStorage, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            while (streamReader.EndOfStream == false)
            {
                nameList.Add(streamReader.ReadLine());
            }

            streamReader.Close();
            fileStream.Close();
            nameList.TrimExcess();

            Random RNG = new Random();
            return nameList[RNG.Next(nameList.Count)].CapitalizeNames();
        }

        private static string NameFromSource()
        {
            if (_playerCounter % 2 == 0)
            {
                switch (new Random().Next(28))
                {
                    case 0: return "Anna-Lena";
                    case 1: return "Anna-Liesa";
                    case 2: return "Anna-Lisa";
                    case 3: return "Annastacia";
                    case 4: return "Annastasia";
                    case 5: return "Annabelle";
                    case 6: return "Annabell";
                    case 7: return "Annabel";
                    case 8: return "Annalena";
                    case 9: return "Annaliesa";
                    case 10: return "Annalisa";
                    case 11: return "Annais";
                    case 12: return "Anna";
                    case 13: return "Anni";
                    case 14: return "Ann";
                    default: return NameFromSource().Replace("nn", "n");
                }
            }
            else
            {
                switch (new Random().Next(18))
                {
                    case 0: return "Karl-Theodor";
                    case 1: return "Karl-Heinz";
                    case 2: return "Karlmann";
                    case 3: return "Karlman";
                    case 4: return "Karlsson";
                    case 5: return "Karlson";
                    case 6: return "Karla";
                    case 7: return "Karli";
                    case 8: return "Karlo";
                    case 9: return "Karl";
                    default: return NameFromSource().Replace("K", "C");
                }
            }
        }

        private static string SymbolFromList()
        {
            string symbol = string.Empty;

            // Assign the "X" symbol to the first player
            // Assign the "O" symbol to the second player
            // Keep alternating symbol assignment for future players of this app's instance
            if (_playerCounter % 2 == 0)
            {
                symbol = "O";
            }
            else
            {
                symbol = "X";
            }

            return symbol;
        }

        private static Bitmap AvatarFromList()
        {
            // relative path from solution (tictactoe_app)
            string solutionPath_2 = Path.Combine("tictactoe_cli", "Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");
            // relative path from project (tictactoe_cli)
            string projectPath_2 = Path.Combine("Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");
            // DEFAULT Current Directory in DEBUG: '${HOME}\Source\Repos\seromaho\tictactoe_app\tictactoe_cli\bin\Debug\netcoreapp3.1'
            string debugPath_2 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");
            // DEFAULT Current Directory in RELEASE: '${HOME}\source\repos\seromaho\tictactoe_app\tictactoe_cli\bin\Release\netcoreapp3.1\publish'
            string releasePath_2 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");

            // Get the symbol image from "tictactoe_app\tictactoe_cli\Data\Images\"
            string symbol_2;
            if (File.Exists(solutionPath_2)) { symbol_2 = solutionPath_2; }
            else if (File.Exists(projectPath_2)) { symbol_2 = projectPath_2; }
            else if (File.Exists(releasePath_2)) { symbol_2 = releasePath_2; }
            else if (File.Exists(debugPath_2)) { symbol_2 = debugPath_2; }
            else { symbol_2 = string.Empty; }

            // relative path from solution (tictactoe_app)
            string solutionPath_1 = Path.Combine("tictactoe_cli", "Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");
            // relative path from project (tictactoe_cli)
            string projectPath_1 = Path.Combine("Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");
            // DEFAULT Current Directory in DEBUG: '${HOME}\Source\Repos\seromaho\tictactoe_app\tictactoe_cli\bin\Debug\netcoreapp3.1'
            string debugPath_1 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");
            // DEFAULT Current Directory in RELEASE: '${HOME}\source\repos\seromaho\tictactoe_app\tictactoe_cli\bin\Release\netcoreapp3.1\publish'
            string releasePath_1 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");

            // Get the symbol image from "tictactoe_app\tictactoe_cli\Data\Images\"
            string symbol_1;
            if (File.Exists(solutionPath_1)) { symbol_1 = solutionPath_1; }
            else if (File.Exists(projectPath_1)) { symbol_1 = projectPath_1; }
            else if (File.Exists(releasePath_1)) { symbol_1 = releasePath_1; }
            else if (File.Exists(debugPath_1)) { symbol_1 = debugPath_1; }
            else { symbol_1 = string.Empty; }

            // Assign the "X" symbol image to the first player
            // Assign the "O" symbol image to the second player
            // Keep alternating symbol image assignment for future players of this app's instance
            if (_playerCounter % 2 == 0)
            {
                return new Bitmap(symbol_2);
            }
            else
            {
                return new Bitmap(symbol_1);
            }
        }
    }
}
