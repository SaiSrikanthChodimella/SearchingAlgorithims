
using System;

namespace SearchingAlgorithims
{
    class ParallelBinarySearch
    {
       public static int Search(int[] sortedArray, int target)
        {
            var index = 0;

            Parallel.For(0, sortedArray.Length, (i,state) =>
            {
                index = Array.BinarySearch(sortedArray, target);
                if (sortedArray[index] == target)
                {
                    state.Stop();
                }
            });

            return index == -1 ? -1 : sortedArray[index];
        }
    }
}
