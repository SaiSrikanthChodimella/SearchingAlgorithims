namespace SearchingAlgorithims
{
    public static class InterpolationSearch
    {
        public static int Search(int[] sortedArray, int target)
        {
            long low = 0;
            long high = sortedArray.Length - 1;

            while (low <= high && target >= sortedArray[low] && target <= sortedArray[high])
            {
                long probeNumerator = (target - sortedArray[low]) * (high - low);
                long probeDenominator = sortedArray[high] - sortedArray[low];

                var position = low + probeNumerator / probeDenominator;

                if (sortedArray[position] == target)
                {
                    return sortedArray[position];
                }
                else if (sortedArray[position] < target)
                {
                    low = position + 1;
                }
                else
                {
                    high = position - 1;
                }
            }
            return -1;
        }
    }
}
