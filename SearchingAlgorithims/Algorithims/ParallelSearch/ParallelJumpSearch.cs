namespace SearchingAlgorithims
{
    public static class ParallelJumpSearch
    {
        public static int Search(int[] sortedArray, int target)
        {
            int step = (int)Math.Sqrt(sortedArray.Length);
            int result = -1;

            Parallel.For(0, sortedArray.Length / step, (i, state) =>
            {
                int blockStart = i * step;
                int blockEnd = Math.Min(blockStart + step, sortedArray.Length);

                if (sortedArray[blockEnd - 1] >= target)
                {
                    for (int j = blockStart; j < blockEnd; j++)
                    {
                        if (sortedArray[j] == target)
                        {
                            result = j;
                            state.Stop();
                        }
                    }
                }
            });

            return sortedArray[result];
        }
    }
}
