namespace SearchingAlgorithims
{
    public static class ExponentialSearch
    {
        public static int Search(int[] array, int target)
        {
            if (array[0] == target)
            {
                return array[0];
            }
            var i = 1;

            while (i < array.Length && array[i] <= target)
            {
                i *= 2;
            }

            var leftBound = i / 2;
            var rightBound = Math.Min(i, array.Length - 1);
            var result = BinarySearch(array, target, leftBound, rightBound);
            return result;
        }

        private static int BinarySearch(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (array[middle] == target)
                {
                    return array[middle];
                }
                else if (array[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }
    }
}
