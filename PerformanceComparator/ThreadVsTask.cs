using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerformanceComparator
{
    public class ThreadVsTask
    {
        [Params (10,20)]
        public int a { get; set; }

        [Benchmark]
        public void DoArithematicOperationUsingThread()
        {
            Thread factorial=new Thread(_ => Factorial(a));
            Thread print = new Thread(_ => PrintFactorial());
            factorial.Start();
            print.Start();
            print.Join();
            factorial.Join();
        }

        public void Factorial(int a)
        {
            for(int i=a;i<0;i--)
            {
                a= a * i;
            }
        }

        public void PrintFactorial()
        {
            
        }

        [Benchmark]
        public void DoArithematicOperationUsingTask()
        {
            Task.Run(async () =>

            {

                var factorial = FactorialTask(a);

                var print = PrintFactorialTask();

                await Task.WhenAll(factorial, print);

            }).GetAwaiter().GetResult();
        }

        public async static Task FactorialTask(int a)
        {
            for (int i = a; i < 0; i--)
            {
                a = a * i;
            }
        }

        public async static Task PrintFactorialTask()
        {

        }
    }
}
