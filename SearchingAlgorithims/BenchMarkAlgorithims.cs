using BenchmarkDotNet.Attributes;
using SearchingAlgorithims;

namespace SortingAlgorithims
{
    [MemoryDiagnoser]
    public class BenchMarkAlgorithims
    {
        private int[] _sortedArray;

        private int target;

        [Params(1_000_000)]
        public int arraysize;

        [GlobalSetup]
        public void Setup()
        {
            _sortedArray = SortedArrayGenerator.SortedArray(arraysize);
            target = _sortedArray[arraysize / 2];
        }

        [Benchmark]
        public int LinearSearchBenchMark() => LinearSearch.Search(_sortedArray, target);

        [Benchmark]
        public int BinarySearchBenchMark() => BinarySearch.Search(_sortedArray, target);

        [Benchmark]
        public int InterpolationSearchBenchMark() => InterpolationSearch.Search(_sortedArray, target);

        [Benchmark]
        public int JumpSearchBenchMark() => JumpSearch.Search(_sortedArray, target);

        [Benchmark]
        public int HashSearchBenchMark() => HashSet.Search(_sortedArray, target);

        [Benchmark]
        public int ExponentialSearchBenchMark() => ExponentialSearch.Search(_sortedArray, target);

        [Benchmark]
        public int TernarySearchBenchMark() => TernarySearch.Search(_sortedArray, target);

        [Benchmark]
        public int ParallelLinearSearchBenchMark() => ParallelLinearSearch.Search(_sortedArray, target);

        [Benchmark]
        public int ParallelBinarySearchBenchMark() => ParallelBinarySearch.Search(_sortedArray, target);

        [Benchmark]
        public int ParallelHashSetBenchMark() => ParallelHashSet.Search(_sortedArray, target);

        [Benchmark]
        public int ParallelJumpSearchBenchMark() => ParallelJumpSearch.Search(_sortedArray, target);
    }
}
