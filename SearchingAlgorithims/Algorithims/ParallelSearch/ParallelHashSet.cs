using Microsoft.Diagnostics.Runtime.Utilities;
using System.Collections.Concurrent;

namespace SearchingAlgorithims
{
    public static class ParallelHashSet
    {
        public static int Search(int[] sortedArray, int target)
        {
            var dictionary = new ConcurrentDictionary<int, int>();
            int index = -1;

            Parallel.For(0, sortedArray.Length, (i) =>
            {
                dictionary[sortedArray[i]] = i;
            });

            Parallel.ForEach(dictionary, (kvp, state) =>
            {
                if (kvp.Key == target)
                {
                    index = kvp.Value;
                    state.Stop();
                }
            });
            return sortedArray[index];
        }
    }
}
