using System.Collections.Generic;
using System.Linq;

namespace CodeWarsKatas.katas._6_kyu
{
    // https://www.codewars.com/kata/57ea70aa5500adfe8a000110/train/csharp
    static class FoldAnArray
    {
        public static int[] FoldArray(int[] array, int runs)
        {
            List<int> arr = array.ToList();
            for (int c = 0; c < runs; c++)
            {
                int cou = arr.Count;
                for (int i = 0; i < (cou / 2); i++)
                {
                    arr[i] = arr[i] + arr[cou - i - 1];

                    arr.RemoveAt(cou - i - 1);
                }
            }
            return arr.ToArray();
        }
        }
    }
