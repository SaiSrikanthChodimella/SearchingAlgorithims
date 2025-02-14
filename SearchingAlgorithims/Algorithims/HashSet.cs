namespace SearchingAlgorithims
{
    public static class HashSet
    {
        public static int Search(int[] sortedArray, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                dictionary[sortedArray[i]] = i;
            }
            if (dictionary.TryGetValue(target, out int index))
            {
                return sortedArray[index];
            }
            else
            {
                return -1;
            }
        }
    }
}
