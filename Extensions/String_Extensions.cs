using System;

namespace Extensions
{
    public static class String_Extensions
    {
        public static string CapitalizeFirstLetter(this string inputString)
        {
            int charIndex = 0;
            // Create a char array from input string
            char[] charArray = new char[inputString.Length];
            foreach (char zeichen in inputString)
            {
                charArray[charIndex] = zeichen;
                charIndex++;
            }

            // Convert the first char of the char array to be upper case
            string firstLetter = new string(charArray[0], 1);
            charArray[0] = Convert.ToChar(firstLetter.ToUpper());

            // Create an input string out of the char array
            string outputString = new string(charArray);
            return outputString;
        }

        public static string CapitalizeNames(this string inputString)
        {
            string outputString = string.Empty;
            // If the input string contains any dashes
            // Split the input string into substrings delimited by dashes
            if (inputString.Contains("-"))
            {
                // Capitalize each substring and combine them back into their superstring
                string[] nameParts = inputString.Split('-');
                foreach (string namePart in nameParts)
                {
                    outputString += namePart.CapitalizeFirstLetter() + "-";
                }
                outputString = outputString.TrimEnd('-');
            }
            else
            {
                // If the input string contains no dashes
                // Convert the first letter of the input string to be upper case
                outputString = inputString.CapitalizeFirstLetter();
            }

            return outputString;
        }
    }
}
