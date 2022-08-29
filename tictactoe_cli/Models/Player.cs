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
            // Let the current player enter their name
            Console.CursorVisible = true;
            Console.WriteLine("- - - PLAYER {0} - - -", _playerCounter);
            Console.WriteLine("Enter your name or leave empty to get a random name:");
            string input = Console.ReadLine();

            // Assign a random name if none was entered
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                input = NameFromList();
            }
            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop - 1);
            Console.WriteLine("Your name is: {0}.", input);

            return input;
        }

        private static string NameFromList()
        {
            Console.CursorVisible = false;

            // relative path from solution (tictactoe_app)
            string appPath = Path.Combine("tictactoe_cli", "Data", "names.txt");
            // relative path from project (tictactoe_cli)
            string cliPath = Path.Combine("Data", "names.txt");
            // DEFAULT Current Directory in DEBUG: '${HOME}\Source\Repos\seromaho\tictactoe_app\tictactoe_cli\bin\Debug\netcoreapp3.1'
            string debugPath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "names.txt");
            // DEFAULT Current Directory in RELEASE: '${HOME}\source\repos\seromaho\tictactoe_app\tictactoe_cli\bin\Release\netcoreapp3.1\publish'
            string releasePath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName, "Data", "names.txt");

            // Get a random name from "tictactoe_app\tictactoe_cli\Data\names.txt" and make its first letter upper case
            string nameListStorage;
            if (File.Exists(appPath)) { nameListStorage = appPath; }
            else if (File.Exists(cliPath)) { nameListStorage = cliPath; }
            else if (File.Exists(releasePath)) { nameListStorage = releasePath; }
            else if (File.Exists(debugPath)) { nameListStorage = debugPath; }
            else { nameListStorage = string.Empty; }

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
            return nameList[RNG.Next(nameList.Count)].CapitalizeFirstLetter();
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
            string appPath_2 = Path.Combine("tictactoe_cli", "Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");
            // relative path from project (tictactoe_cli)
            string cliPath_2 = Path.Combine("Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");
            // DEFAULT Current Directory in DEBUG: '${HOME}\Source\Repos\seromaho\tictactoe_app\tictactoe_cli\bin\Debug\netcoreapp3.1'
            string debugPath_2 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");
            // DEFAULT Current Directory in RELEASE: '${HOME}\source\repos\seromaho\tictactoe_app\tictactoe_cli\bin\Release\netcoreapp3.1\publish'
            string releasePath_2 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-2-white-25x25.png");

            // Get the symbol images from "tictactoe_app\tictactoe_cli\Data\Images\"
            string symbol_2;
            if (File.Exists(appPath_2)) { symbol_2 = appPath_2; }
            else if (File.Exists(cliPath_2)) { symbol_2 = cliPath_2; }
            else if (File.Exists(releasePath_2)) { symbol_2 = releasePath_2; }
            else if (File.Exists(debugPath_2)) { symbol_2 = debugPath_2; }
            else { symbol_2 = string.Empty; }

            // relative path from solution (tictactoe_app)
            string appPath_1 = Path.Combine("tictactoe_cli", "Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");
            // relative path from project (tictactoe_cli)
            string cliPath_1 = Path.Combine("Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");
            // DEFAULT Current Directory in DEBUG: '${HOME}\Source\Repos\seromaho\tictactoe_app\tictactoe_cli\bin\Debug\netcoreapp3.1'
            string debugPath_1 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");
            // DEFAULT Current Directory in RELEASE: '${HOME}\source\repos\seromaho\tictactoe_app\tictactoe_cli\bin\Release\netcoreapp3.1\publish'
            string releasePath_1 = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName, "Data", "Images", "tic-tac-toe-symbol-1-white-25x25.png");

            // Get the symbol images from "tictactoe_app\tictactoe_cli\Data\Images\"
            string symbol_1;
            if (File.Exists(appPath_1)) { symbol_1 = appPath_1; }
            else if (File.Exists(cliPath_1)) { symbol_1 = cliPath_1; }
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
