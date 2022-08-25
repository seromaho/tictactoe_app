using System;
using System.Threading;

namespace Extensions
{
    public static class Console_Extensions
    {
        public static void halfScreenSizedWindow()
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight);
        }

        public static void Ladebalken()
        {
            Random RNG = new Random();

            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop + 2);

            for (int index = 0; index < 50; index++)
            {
                Console.SetCursorPosition(22, Console.CursorTop);
                Console.Write(" {0,2} % ", (index) * 2);
                Thread.Sleep(RNG.Next(50));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("-");
                Thread.Sleep(RNG.Next(50));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("\\");
                Thread.Sleep(RNG.Next(50));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("|");
                Thread.Sleep(RNG.Next(50));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("/");
                Thread.Sleep(RNG.Next(50));
            }

            Console.Clear();
        }
    }
}
