namespace SearchingAlgorithims
{
    public static class TernarySearch
    {
        public static int Search(int[] array, int target)
        {
            var leftBound = 0;
            var rightBound = array.Length - 1;

            while (leftBound <= rightBound)
            {
                var piviot_one = leftBound + (rightBound - leftBound) / 3;
                var pivot_two = rightBound - (rightBound - leftBound) / 3;

                if (array[piviot_one] == target)
                {
                    return array[piviot_one];
                }

                if (array[pivot_two] == target)
                {
                   return array[pivot_two];
                }

                if (target < array[piviot_one])
                {
                    rightBound = piviot_one - 1;
                }
                else if (target > array[pivot_two])
                {
                    leftBound = pivot_two + 1;
                }
                else
                {
                    leftBound = piviot_one + 1;
                    rightBound = pivot_two - 1;
                }
            }
            return -1;
        }
    }
}
