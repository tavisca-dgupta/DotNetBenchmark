using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.


            var forVsForeach = BenchmarkRunner.Run<ForVsForeach>();
            var arrayVsList = BenchmarkRunner.Run<ArrayVsList>();
            var stringVsStringBuilder = BenchmarkRunner.Run<StringVsStringBuilder>();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

    }
}
