using System.Collections.Generic;
using System.Linq;

namespace CodeWarsKatas.katas._6_kyu
{
    // https://www.codewars.com/kata/569d488d61b812a0f7000015/train/csharp
    public class DataReverse
    {
        public static int[] DataReverser(int[] data)
        {
            var slicedSegments = new List<int[]>();

            for (var i = 0; i < data.Length; i+=8)
            {
                var item = data.Skip(i).Take(8);
                slicedSegments.Add(item.ToArray());
            }

            slicedSegments.Reverse();

            return slicedSegments.SelectMany(slicedSegment => slicedSegment).ToArray();
        }
    }
}