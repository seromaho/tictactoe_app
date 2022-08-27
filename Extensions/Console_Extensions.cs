using System;
using System.Threading;

namespace Extensions
{
    public static class Console_Extensions
    {
        public static void FitWindowAndBufferSize()
        {
            // Set the console window width to fit the application
            // Set the console window height to fit the screen
            Console.SetWindowSize(111, Console.LargestWindowHeight);

            // Set the screen buffer area width to fit the application
            Console.SetBufferSize(111, Console.BufferHeight);
        }

        public static void RestoreWindowAndBufferSize(Tuple<int, int> windowSize, int bufferWidth)
        {
            // Revert the changes made to console window width and console window height
            // by parsing in the original values
            Console.SetWindowSize(windowSize.Item1, windowSize.Item2);

            // Revert the changes made to the screen buffer area width
            // by parsing in the original values
            Console.SetBufferSize(bufferWidth, Console.BufferHeight);
        }

        public static void LoadingBar()
        {
            Random RNG = new Random();
            // Draw a loading bar, then clear the console buffer

            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop + 2);

            for (int index = 0; index < 50; index++)
            {
                Console.SetCursorPosition(22, Console.CursorTop);
                Console.Write(" {0,2} % ", (index) * 2);
                Thread.Sleep(RNG.Next(20));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("-");
                Thread.Sleep(RNG.Next(20));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("\\");
                Thread.Sleep(RNG.Next(20));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("|");
                Thread.Sleep(RNG.Next(20));
                Console.SetCursorPosition(index, Console.CursorTop);
                Console.Write("/");
                Thread.Sleep(RNG.Next(20));
            }

            Console.Clear();
        }
    }
}
