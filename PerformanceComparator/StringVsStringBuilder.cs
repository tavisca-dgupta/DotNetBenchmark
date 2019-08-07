using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparator
{
    public class StringVsStringBuilder
    {
        [Params("hello","goodmorning")]
        public string greeting { get; set; }

        [Params("Jhon", "Harry")]
        public string name { get; set; }

        [Benchmark]
        public void ConcateUsingString()
        {
            string message;
            for (int i=0;i<10;i++)
             message = string.Concat(greeting, name);
        }

        [Benchmark]
        public void ConcateUsingStringBuilder()
        {
            StringBuilder message = new StringBuilder(greeting);
            for(int i=0;i<10;i++)
            {
                message.AppendLine(name);
            }
        }
    }
}
