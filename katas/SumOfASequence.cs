using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsKatas.katas
{
    /// <summary>
    //Your task is to make function, which returns the sum of a sequence of integers.
    //    The sequence is defined by 3 non-negative values: begin, end, step.
    //    If begin value is greater than the end, function should returns 0
    //Examples

    //SequenceSum (2,2,2); // => 2
    //SequenceSum(2, 6, 2); // => 12 -> 2 + 4 + 6
    //SequenceSum(1, 5, 1); // => 15 -> 1 + 2 + 3 + 4 + 5
    //SequenceSum(1, 5, 3); // => 5 -> 1 + 4
    /// </summary>
    static class SumOfASequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int finalCount = 0;

            if (start > end)
            {
                return -1;
            }
            else
            {

                int i = start;
                finalCount += start;
                do
                {
                    finalCount += step;
                    i += step;
                } while (i <= end);
                

                return finalCount;
            }
        }
    }
}

//SequenceSum(2, 2, 2); // => 2
//SequenceSum(2, 6, 2); // => 12 -> 2 + 4 + 6
//SequenceSum(1, 5, 1); // => 15 -> 1 + 2 + 3 + 4 + 5
//SequenceSum(1, 5, 3); // => 5 -> 1 + 4