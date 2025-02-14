namespace SortingAlgorithims
{
    public static class SortedArrayGenerator
    {
        public static int[] SortedArray(int size)
        {
            var randomArray = RandomArray(size);
            Array.Sort(randomArray);

            return randomArray;
        }

        private static int[] RandomArray(int size)
        {
            var randomAray = new int[size];
            var random = new Random();

            for (var i = 0; i < size; i++)
            {
                randomAray[i] = random.Next(0, size);
            }

            return randomAray;
        }
    }
}
