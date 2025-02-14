# Searching Algorithms Benchmarking Project

This project benchmarks the performance of various searching algorithms using BenchmarkDotNet. The goal is to compare the efficiency of different algorithms on large datasets and understand their performance characteristics.

## Table of Contents
- [Project Overview](#project-overview)
- [Algorithms Benchmarked](#algorithms-benchmarked)
- [Setup](#setup)
- [Running the Benchmarks](#running-the-benchmarks)
- [Results](#results)
- [Contributing](#contributing)
- [License](#license)

## Project Overview
This project benchmarks the following searching algorithms:

### Searching Algorithms:
- **Linear Search**
- **Binary Search**
- **Interpolation Search**
- **Jump Search**
- **Hash-Based Search**
- **Exponential Search**
- **Ternary Search**
- **Parallel Linear Search**
- **Parallel Binary Search**
- **Parallel Hash-Based Search**
- **Parallel Jump Search**

The benchmarks are run on a sorted array of 1,000,000 elements to compare the performance of each algorithm. The project uses BenchmarkDotNet to measure execution time and memory allocation.

## Algorithms Benchmarked
### 1. Linear Search
- **Description**: Iterates through each element in the array until the target is found.
- **Time Complexity**: O(n)
- **Use Case**: Suitable for small or unsorted datasets.

### 2. Binary Search
- **Description**: Efficiently searches a sorted array by repeatedly dividing the search interval in half.
- **Time Complexity**: O(log n)
- **Use Case**: Ideal for large, sorted datasets.

### 3. Interpolation Search
- **Description**: Improved version of Binary Search for uniformly distributed datasets. Estimates the position of the target.
- **Time Complexity**: O(log log n) on average, O(n) in the worst case.
- **Use Case**: Best for large, uniformly distributed, sorted datasets.

### 4. Jump Search
- **Description**: Searches a sorted array by jumping ahead in fixed steps and then performing a linear search within the block.
- **Time Complexity**: O(\sqrt{n})
- **Use Case**: Suitable for large, sorted datasets.

### 5. Hash-Based Search
- **Description**: Uses a hash table (e.g., HashSet) to store and retrieve elements in constant time.
- **Time Complexity**: O(1) on average for lookups.
- **Use Case**: Ideal for fast lookups in large datasets.

### 6. Exponential Search
- **Description**: Combines Binary Search and Linear Search. It starts with a small range and exponentially increases it until the target is within the range.
- **Time Complexity**: O(log n)
- **Use Case**: Ideal for unbounded or large sorted datasets.

### 7. Ternary Search
- **Description**: Similar to Binary Search but divides the array into three parts instead of two.
- **Time Complexity**: O(log₃ n)
- **Use Case**: Suitable for large, sorted datasets.

### 8. Parallel Linear Search
- **Description**: Parallelized version of Linear Search that divides the array into chunks and searches each chunk in parallel.
- **Time Complexity**: O(n/p), where p is the number of processors.
- **Use Case**: Suitable for large datasets and multi-core processors.

### 9. Parallel Binary Search
- **Description**: Parallelized version of Binary Search that divides the array into sub-arrays and searches each sub-array in parallel.
- **Time Complexity**: O(log n)
- **Use Case**: Suitable for large, sorted datasets and multi-core processors.

### 10. Parallel Hash-Based Search
- **Description**: Parallelized version of Hash-Based Search that divides the keys into chunks and searches each chunk in parallel.
- **Time Complexity**: O(1) on average for lookups.
- **Use Case**: Ideal for fast lookups in large datasets and multi-core processors.

### 11. Parallel Jump Search
- **Description**: Parallelized version of Jump Search that divides the array into blocks and searches each block in parallel.
- **Time Complexity**: O(\sqrt{n}/p), where p is the number of processors.
- **Use Case**: Suitable for large, sorted datasets and multi-core processors.

## Setup
### Prerequisites
- .NET SDK (version 6.0 or later)
- BenchmarkDotNet (included in the project)

### Steps
Clone the repository:
```bash
git clone https://github.com/your-username/sorting-searching-benchmark.git
```

Navigate to the project directory:
```bash
cd sorting-searching-benchmark
```

Restore the dependencies:
```bash
dotnet restore
```

## Running the Benchmarks
To run the benchmarks, use the following command:
```bash
dotnet run -c Release
```
This will execute the benchmarks in Release mode (required for accurate benchmarking) and display the results in the console.

## Results
The benchmarks will output detailed performance metrics, including:
- **Mean time**: The average time taken to perform the search.
- **Allocated memory**: The amount of memory allocated during the search.
- **Standard deviation**: The variation in execution times.

### Example Output
```
Method                          ArraySize    Mean       Error      StdDev    Allocated
LinearSearchBenchMark           1,000,000    100.23 ns   1.234 ns   1.123 ns   0 B
BinarySearchBenchMark           1,000,000    50.12 ns    0.567 ns   0.456 ns   0 B
InterpolationSearchBenchMark    1,000,000    20.34 ns    0.345 ns   0.234 ns   0 B
JumpSearchBenchMark             1,000,000    30.45 ns    0.456 ns   0.345 ns   0 B
HashSearchBenchMark             1,000,000    10.12 ns    0.123 ns   0.112 ns   0 B
ExponentialSearchBenchMark      1,000,000    40.56 ns    0.567 ns   0.456 ns   0 B
ParallelLinearSearchBenchMark   1,000,000    50.12 ns    0.567 ns   0.456 ns   0 B
ParallelBinarySearchBenchMark   1,000,000    25.34 ns    0.345 ns   0.234 ns   0 B
ParallelHashSetBenchMark        1,000,000    5.12 ns     0.123 ns   0.112 ns   0 B
ParallelJumpSearchBenchMark     1,000,000    15.45 ns    0.456 ns   0.345 ns   0 B
```

## Contributing
Contributions are welcome! If you'd like to add more algorithms or improve the benchmarking process, follow these steps:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add your feature"
   ```
4. Push to the branch:
   ```bash
   git push origin feature/your-feature-name
   ```
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE.md](LICENSE.md) file for details.

