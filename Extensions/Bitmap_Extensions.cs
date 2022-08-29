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
            int originalLeft = Console.CursorLeft;
            int originalTop = Console.CursorTop;
            int initialLeft = 60;

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

            Console.SetCursorPosition(initialLeft, Console.CursorTop - Console.CursorTop + 3);
            Console.WriteLine("Your symbol is:");
            Console.SetCursorPosition(initialLeft, Console.CursorTop);

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

                Console.SetCursorPosition(initialLeft, Console.CursorTop);
            }

            Console.SetCursorPosition(originalLeft, originalTop);
        }

        public static void ToAsciiBlackForeground(this Bitmap image)
        {
            int originalLeft = Console.CursorLeft;
            int originalTop = Console.CursorTop;
            int initialLeft = 60;

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

            Console.SetCursorPosition(initialLeft, Console.CursorTop - Console.CursorTop + 3);
            Console.WriteLine("Your symbol is:");
            Console.SetCursorPosition(initialLeft, Console.CursorTop);

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

                Console.SetCursorPosition(initialLeft, Console.CursorTop);
            }

            Console.SetCursorPosition(originalLeft, originalTop);
        }
    }
}
