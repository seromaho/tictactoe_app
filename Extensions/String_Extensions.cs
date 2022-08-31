using System;

namespace Extensions
{
    public static class String_Extensions
    {
        //public static string CapitalizeFirstLetter(this string inputString)
        //{
        //    int charIndex = 0;
        //    // Create a char array from input string
        //    char[] charArray = new char[inputString.Length];
        //    foreach (char zeichen in inputString)
        //    {
        //        charArray[charIndex] = zeichen;
        //        charIndex++;
        //    }

        //    // Convert the first char of the char array to be upper case
        //    string firstLetter = new string(charArray[0], 1);
        //    firstLetter = firstLetter.ToUpper();
        //    foreach (char zeichen in firstLetter) { charArray[0] = zeichen; }

        //    // Create an input string out of the char array
        //    string outputString = new string(charArray);
        //    return outputString;
        //}

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
    }
}
