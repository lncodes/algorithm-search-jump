using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Jump.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class JumpSearchBenchmark
    {
        private readonly int Element = 10;
        private readonly int[] Data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private readonly JumpSearch _jumpSearch = new JumpSearch();

        [Benchmark]
        public int Search() =>
            _jumpSearch.Search(Data, Element);
    }
}