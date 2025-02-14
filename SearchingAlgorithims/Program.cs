using BenchmarkDotNet.Running;
using SortingAlgorithims;

namespace SearchingAlgorithims
{
    internal class Program
    {
        static void Main(string[] args) => BenchmarkRunner.Run<BenchMarkAlgorithims>();
    }
}
