using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsKatas.katas
{
    /// <summary>
    /// You will be given an array of numbers.You have to sort the odd numbers in ascending order while
    /// leaving the even numbers at their original positions.
    /// </summary>
    static class  SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            List<int> oddNumbers = new List<int>();
            List<int> sortedNumbers = new List<int>();

            foreach (var number in array)
            {
                if (number % 2 == 1)
                {
                    oddNumbers.Add(number);
                }
            }

            oddNumbers.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sortedNumbers.Add(array[i]);
                }
                else
                {
                     sortedNumbers.Add(oddNumbers.ElementAt(0));
                     oddNumbers.RemoveAt(0);
                }
            }

            return sortedNumbers.ToArray();
        }
    }
}