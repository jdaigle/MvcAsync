﻿using BenchmarkDotNet.Running;

namespace MvcAsync.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<AsyncControllerActionInvokerBenchmark>();
        }
    }
}