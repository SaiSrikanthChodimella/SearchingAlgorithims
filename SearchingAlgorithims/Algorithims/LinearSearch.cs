namespace SearchingAlgorithims
{
    public static class LinearSearch
    {
        public static int Search(int[] sortedArray, int target)
        {
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] == target)
                {
                    return sortedArray[i];
                }
            }
            return -1;
        }
    }
}
