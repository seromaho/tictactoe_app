using Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace tictactoe_cli.Models
{
    class Player : IPlayer
    {
        public string Name { get; set; }
        public Bitmap Avatar { get; set; }
        public char Symbol { get; set; }

        public Player()
        {
            Name = NameFromInput();
            Avatar = AvatarFromInput();
        }

        private static string NameFromInput()
        {
            Console.WriteLine("Enter your name or leave empty to get a random name:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                input = NameFromList();
            }

            Console.WriteLine("Your name is {0}.", input);
            return input;
        }

        private static string NameFromList()
        {
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

        private static Bitmap AvatarFromInput()
        {
            List<Bitmap> bitmapList = new List<Bitmap>();
            foreach (var image in Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images")))
            {
                bitmapList.Add(new Bitmap(image));
            }
            bitmapList.TrimExcess();

            return bitmapList.ToArray()[0];

            // Console.WriteLine("Enter the number of your avatar or leave empty to get a random avatar:");
        }
    }
}
