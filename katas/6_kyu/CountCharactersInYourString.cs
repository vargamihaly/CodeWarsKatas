using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsKatas.katas._6_kyu
{
    // https://www.codewars.com/kata/52efefcbcdf57161d4000091/csharp
    public class CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> countedLetters = new Dictionary<char, int>();

            foreach (var letter in str)
            {
                if (countedLetters.ContainsKey(letter))
                {
                    countedLetters[letter] += 1;
                }
                else
                {
                    countedLetters.Add(letter, 1);
                }
            }

            return countedLetters;
        }
    }
}