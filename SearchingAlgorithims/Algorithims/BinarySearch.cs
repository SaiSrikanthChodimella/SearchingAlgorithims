namespace SearchingAlgorithims
{
    class BinarySearch
    {
        internal static int Search(int[] sortedArray, int target)
        {
            var index = Array.BinarySearch(sortedArray, target);
            return index == -1 ? -1 : sortedArray[index];
        }
    }
}
