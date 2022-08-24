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
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //foreach (string item in Directory.GetDirectories(Directory.GetCurrentDirectory()))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName);
            //Console.WriteLine(Path.Combine("..", "..", "..", "Data", "name.txt"));

            Player player_1 = new Player();

            foreach (var image in Directory.GetFiles(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Data", "Images")))
            {
                Console.WriteLine(image);
            }

            Console.ReadKey();
        }
    }
}
