using Extensions;
using System;
using System.Drawing;
using System.IO;

namespace tictactoe_cli.Models
{
    class Player : IPlayer
    {
        private static int _playerCounter = 0;
        public string Name { get; set; }
        public Bitmap Avatar { get; set; }
        public string Symbol { get; set; }
        public int NumGamesWon { get; set; }
        public int NumGamesLost { get; set; }

        public Player()
        {
            _playerCounter++;
            Name = NameFromInput();
            Symbol = SymbolFromList();
            //Avatar = AvatarFromList();
            NumGamesWon = 0;
            NumGamesLost = 0;

            Console_Extensions.Ladebalken();
        }

        private static string NameFromInput()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("- - - PLAYER {0} - - -", _playerCounter);
            Console.WriteLine("Enter your name or leave empty to get a random name:");
            string input = Console.ReadLine();

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

            int nameCount = 0;

            // "Could not find a part of the path '${HOME}\\source\\repos\\tictactoe_app\\tictactoe_cli\\bin\\Debug\\netcoreapp3.1\\tictactoe_cli\\Data\\names.txt'."
            FileStream streamReader_0 = new FileStream(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "names.txt"), FileMode.OpenOrCreate);
            StreamReader streamReader_1 = new StreamReader(streamReader_0);
            
            while (streamReader_1.EndOfStream == false)
            {
                streamReader_1.ReadLine();
                nameCount++;
            }

            streamReader_1.Close();
            streamReader_0.Close();

            StreamReader streamReader_3 = new StreamReader(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "names.txt"));

            string[] nameArray = new string[nameCount];
            int nameIndex = 0;

            while (streamReader_3.EndOfStream == false)
            {
                nameArray[nameIndex] = streamReader_3.ReadLine();
                nameIndex++;
            }

            streamReader_3.Close();

            Random RNG = new Random();
            return nameArray[RNG.Next(0, nameArray.Length)].CapitalizeFirstLetter();
        }

        private static string SymbolFromList()
        {
            string symbol = string.Empty;

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

        //private static Bitmap AvatarFromInput()
        //{
        //    string[] imageStorage = Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images"));

        //    List<Bitmap> bitmapList = new List<Bitmap>();
        //    foreach (string image in imageStorage)
        //    {
        //        bitmapList.Add(new Bitmap(image));
        //    }
        //    bitmapList.TrimExcess();

        //    //foreach (Bitmap image in bitmapList)
        //    //{
        //    //    image.ToGrayscaleArray();
        //    //}

        //    Console.WriteLine("Choose an avatar by typing its number:");

        //    foreach (Bitmap image in bitmapList)
        //    {
        //        image.ToAsciiWhiteForeground();
        //    }

        //    return bitmapList.ToArray()[0];

        //    // Console.WriteLine("Enter the number of your avatar or leave empty to get a random avatar:");
        //}

        //private static Bitmap AvatarFromList()
        //{
        //    Console.Clear();
        //    string[] imageStorage = Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images"));

        //    List<Bitmap> bitmapList = new List<Bitmap>();
        //    foreach (string image in imageStorage)
        //    {
        //        bitmapList.Add(new Bitmap(image));
        //    }
        //    bitmapList.TrimExcess();

        //    //Console.Clear();
        //    Console.WriteLine("- - - PLAYER {0} - - -", _playerCounter);
        //    Console.Write("Your avatar is:\t\t\t");

        //    bitmapList.ToArray()[0].ToAsciiWhiteForegroundSetup();

        //    Console.ReadLine();
        //    return bitmapList.ToArray()[0];
        //}
    }
}
