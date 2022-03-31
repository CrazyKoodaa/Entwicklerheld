using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace AnagramImplementation
{
    public static class Anagram
    {
        public static Boolean IsAnagram(String firstWord, String secondWord)
        {
            // Generate list for the second word
            List<char> vs2 = new List<char>();

            // If the Length of both are different, then it's def. no anagram
            if (firstWord.Length != secondWord.Length)
                return false;
            else
            {
                // Add all single chars from secondWord into 
                // the second list
                for (int i = 0; i < firstWord.Length; i++)
                    vs2.Add(secondWord[i]);

                // if the character in vs1 is in the second, 
                // then remove it from the second. That should help, 
                // if there are two same chars in the list
                foreach (char c in firstWord)
                    if (vs2.Contains(c)) vs2.Remove(c);

            }

            // if all chars are deleted in the second list, then it should be ok
            if (vs2.Count == 0)
                return true;
            else
                return false;
        }
    }
}