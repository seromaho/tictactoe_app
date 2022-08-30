using System;
using System.Drawing;

namespace Extensions
{
    public static class Bitmap_Extensions
    {
        public static void ToAsciiArtwork(this Bitmap image)
        {
            // Save the current cursor position
            int originalLeft = Console.CursorLeft;
            int originalTop = Console.CursorTop;
            // Set the starting column position of the cursor
            int initialLeft = 60;

            double[,] grayscaleValues = new double[image.Width, image.Height];
            // Calculate the grayscale value for each pixel of the bitmap
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    double redValue = pixelColor.R;
                    double greenValue = pixelColor.G;
                    double blueValue = pixelColor.B;
                    // Add the RGB values of the current pixel together and divide the result by their number (3) to get the pixel's grayscale value
                    // Divide the grayscale value by the number of possible grayscale values (255) to get a fractional value
                    grayscaleValues[x, y] = Math.Round(((redValue + greenValue + blueValue) / (double)3) / (double)255, 1);
                }
            }

            Console.SetCursorPosition(initialLeft, Console.CursorTop - Console.CursorTop + 3);
            Console.WriteLine("Your symbol is:");
            // Set the cursor to the starting position of the ASCII artwork
            Console.SetCursorPosition(initialLeft, Console.CursorTop);

            string symbol;
            // Assign a letter to each possible grayscale value to represent it
            for (int y = 0; y < grayscaleValues.GetLength(1); y++)
            {
                for (int x = 0; x < grayscaleValues.GetLength(0); x++)
                {
                    switch (grayscaleValues[x, y])
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
                    // Write the letter to STDOUT, two times for each pixel
                    Console.Write("{0}{1}", symbol, symbol);
                }

                Console.Write("\n");
                // Set the cursor position to the beginning of the next line of the ASCII artwork
                Console.SetCursorPosition(initialLeft, Console.CursorTop);
            }

            // Set the cursor back to its original position
            Console.SetCursorPosition(originalLeft, originalTop);
        }
    }
}
