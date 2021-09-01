using BenchmarkDotNet.Running;

namespace Lncodes.Algorithm.Search.Jump.Benchmark
{
    public sealed class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<JumpSearchBenchmark>();
        }
    }
}
