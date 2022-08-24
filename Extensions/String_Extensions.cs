using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class String_Extensions
    {
        public static string CapitalizeFirstLetter(this string inputString)
        {
            char[] charArray = new char[inputString.Length];

            int charIndex = 0;
            foreach (char zeichen in inputString)
            {
                charArray[charIndex] = zeichen;
                charIndex++;
            }

            string firstLetter = new string(charArray[0], 1);
            firstLetter = firstLetter.ToUpper();

            foreach (char zeichen in firstLetter)
            {
                charArray[0] = zeichen;
            }

            string outputString = new string(charArray);
            return outputString;
        }
    }
}
