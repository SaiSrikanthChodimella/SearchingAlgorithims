namespace SearchingAlgorithims
{
    public static class ParallelLinearSearch
    {
        public static int Search(int[] sortedArray, int target)
        {
            int result = -1;
            Parallel.For(0, sortedArray.Length, (i, state) =>
            {
                if (sortedArray[i] == target)
                {
                    result = sortedArray[i];
                    state.Stop();
                }
            });
            return result;
        }
    }
}
