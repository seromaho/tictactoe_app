using System;
using System.Drawing;

namespace Extensions
{
    public static class Bitmap_Extensions
    {
        public static double[,] ToGrayscaleArray(this Bitmap image)
        {
            double[,] grayscaleARRAY = new double[image.Width, image.Height];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    double red = color.R;
                    double green = color.G;
                    double blue = color.B;

                    grayscaleARRAY[x, y] = Math.Round(((red + green + blue) / (double)3) / (double)255, 1);
                }
            }

            return grayscaleARRAY;
        }

        public static void ToAsciiWhiteForeground(this Bitmap image)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            double[,] grayscaleARRAY = new double[image.Width, image.Height];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    double red = color.R;
                    double green = color.G;
                    double blue = color.B;

                    grayscaleARRAY[x, y] = Math.Round(((red + green + blue) / (double)3) / (double)255, 1);
                }
            }

            Console.SetCursorPosition(54, Console.CursorTop - Console.CursorTop);

            string symbol;

            for (int y = 0; y < grayscaleARRAY.GetLength(1); y++)
            {
                for (int x = 0; x < grayscaleARRAY.GetLength(0); x++)
                {
                    switch (grayscaleARRAY[x, y])
                    {
                        case 0.0: symbol = " "; break;

                        case 0.1: symbol = "."; break;

                        case 0.2: symbol = ":"; break;

                        case 0.3: symbol = "-"; break;

                        case 0.4: symbol = "="; break;

                        case 0.5: symbol = "+"; break;

                        case 0.6: symbol = "*"; break;

                        case 0.7: symbol = "#"; break;

                        case 0.8: symbol = "%"; break;

                        case 0.9: symbol = "@"; break;

                        default: symbol = "@"; break;
                    }

                    Console.Write("{0}{1}", symbol, symbol);
                }

                //Console.Write(" {0,2},{1,2}", Console.CursorLeft, Console.CursorTop);
                //Console.Write(" {0,2},{1,2}", Console.WindowWidth, Console.WindowHeight);
                Console.Write("\n");

                Console.SetCursorPosition(54, Console.CursorTop);
            }

            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop - Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(left, top);
        }

        public static void ToAsciiBlackForeground(this Bitmap image)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            double[,] grayscaleARRAY = new double[image.Width, image.Height];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    double red = color.R;
                    double green = color.G;
                    double blue = color.B;

                    grayscaleARRAY[x, y] = Math.Round(((red + green + blue) / (double)3) / (double)255, 1);
                }
            }

            Console.SetCursorPosition(54, Console.CursorTop - Console.CursorTop);

            string symbol;

            for (int y = 0; y < grayscaleARRAY.GetLength(1); y++)
            {
                for (int x = 0; x < grayscaleARRAY.GetLength(0); x++)
                {
                    switch (grayscaleARRAY[x, y])
                    {
                        case 0.0: symbol = "@"; break;

                        case 0.1: symbol = "%"; break;

                        case 0.2: symbol = "#"; break;

                        case 0.3: symbol = "*"; break;

                        case 0.4: symbol = "+"; break;

                        case 0.5: symbol = "="; break;

                        case 0.6: symbol = "-"; break;

                        case 0.7: symbol = ":"; break;

                        case 0.8: symbol = "."; break;

                        case 0.9: symbol = " "; break;

                        default: symbol = " "; break;
                    }

                    Console.Write("{0}{1}", symbol, symbol);
                }

                //Console.Write(" {0,2},{1,2}", Console.CursorLeft, Console.CursorTop);
                //Console.Write(" {0,2},{1,2}", Console.WindowWidth, Console.WindowHeight);
                Console.Write("\n");

                Console.SetCursorPosition(54, Console.CursorTop);
            }

            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop - Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(left, top);
        }

        public static void ToAsciiWhiteForeground(double[,] grayscaleARRAY)
        {
            string symbol;

            for (int y = 0; y < grayscaleARRAY.GetLength(1); y++)
            {
                for (int x = 0; x < grayscaleARRAY.GetLength(0); x++)
                {
                    switch (grayscaleARRAY[x, y])
                    {
                        case 0.0: symbol = " "; break;

                        case 0.1: symbol = "."; break;

                        case 0.2: symbol = ":"; break;

                        case 0.3: symbol = "-"; break;

                        case 0.4: symbol = "="; break;

                        case 0.5: symbol = "+"; break;

                        case 0.6: symbol = "*"; break;

                        case 0.7: symbol = "#"; break;

                        case 0.8: symbol = "%"; break;

                        case 0.9: symbol = "@"; break;

                        default: symbol = "@"; break;
                    }

                    Console.Write("{0}{1}", symbol, symbol);
                }

                //Console.Write(" {0,2},{1,2}", Console.CursorLeft, Console.CursorTop);
                //Console.Write(" {0,2},{1,2}", Console.WindowWidth, Console.WindowHeight);
                Console.Write("\n");
            }
        }

        public static void ToAsciiBlackForeground(double[,] grayscaleARRAY)
        {
            Console.SetCursorPosition(120, Console.CursorTop - Console.CursorTop);

            string symbol;

            for (int y = 0; y < grayscaleARRAY.GetLength(1); y++)
            {
                for (int x = 0; x < grayscaleARRAY.GetLength(0); x++)
                {
                    switch (grayscaleARRAY[x, y])
                    {
                        case 0.0: symbol = "@"; break;

                        case 0.1: symbol = "%"; break;

                        case 0.2: symbol = "#"; break;

                        case 0.3: symbol = "*"; break;

                        case 0.4: symbol = "+"; break;

                        case 0.5: symbol = "="; break;

                        case 0.6: symbol = "-"; break;

                        case 0.7: symbol = ":"; break;

                        case 0.8: symbol = "."; break;

                        case 0.9: symbol = " "; break;

                        default: symbol = " "; break;
                    }

                    Console.Write("{0}{1}", symbol, symbol);
                }

                //Console.Write(" {0,2},{1,2}", Console.CursorLeft, Console.CursorTop);
                //Console.Write(" {0,2},{1,2}", Console.WindowWidth, Console.WindowHeight);
                Console.Write("\n");
                Console.SetCursorPosition(120, Console.CursorTop);
            }
        }

        public static void ToAsciiWhiteForegroundSetup(this Bitmap image)
        {
            Console.CursorVisible = false;
            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            double[,] grayscaleARRAY = new double[image.Width, image.Height];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);

                    double red = color.R;
                    double green = color.G;
                    double blue = color.B;

                    grayscaleARRAY[x, y] = Math.Round(((red + green + blue) / (double)3) / (double)255, 1);
                }
            }

            Console.SetCursorPosition(left, top);

            string symbol;

            for (int y = 0; y < grayscaleARRAY.GetLength(1); y++)
            {
                for (int x = 0; x < grayscaleARRAY.GetLength(0); x++)
                {
                    switch (grayscaleARRAY[x, y])
                    {
                        case 0.0: symbol = " "; break;

                        case 0.1: symbol = "."; break;

                        case 0.2: symbol = ":"; break;

                        case 0.3: symbol = "-"; break;

                        case 0.4: symbol = "="; break;

                        case 0.5: symbol = "+"; break;

                        case 0.6: symbol = "*"; break;

                        case 0.7: symbol = "#"; break;

                        case 0.8: symbol = "%"; break;

                        case 0.9: symbol = "@"; break;

                        default: symbol = "@"; break;
                    }

                    Console.Write("{0}{1}", symbol, symbol);
                }

                Console.Write("\n");

                Console.SetCursorPosition(left, Console.CursorTop);
            }

            Console.SetCursorPosition(Console.CursorLeft - Console.CursorLeft, Console.CursorTop - Console.CursorTop);
        }
    }
}
