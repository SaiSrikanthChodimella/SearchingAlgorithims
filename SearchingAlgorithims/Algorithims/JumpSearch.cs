namespace SearchingAlgorithims
{
    public static class JumpSearch
    {
        public static int Search(int[] array, int target)
        {
            var step = (int)Math.Sqrt(array.Length);
            var index = 0;

            while (array[Math.Min(step, array.Length) - 1] < target)
            {
                index = step;

                step += (int)Math.Sqrt(array.Length);

                if (index >= array.Length)
                {
                    return -1;
                }
            }

            while (array[index] < target)
            {
                index++;
                if (index == Math.Min(step, array.Length))
                {
                    return -1;
                }
            }

            if (array[index] == target)
            {
                return index;
            }

            return -1;
        }
    }
}
