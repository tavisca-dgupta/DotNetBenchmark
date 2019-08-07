using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceComparator
{
    public class ForVsForeach
    {
        [Params(10)]
        public int countNumber { get; set; }

        private static List<int> intList1 = new List<int>();
        private static List<int> intList2 = new List<int>();
        private static List<int> intList3 = new List<int>();

       
        public void InitializeList()
        {
            for (int i = 0; i < countNumber; i++)
            {
                intList1.Add(i);
            }
        }

        [Benchmark]
        public void AddNumberInListUsingFor()
        {
            for (int i = 0; i < intList1.Count;i++)
            {
                intList2.Add(intList1[i]);
            }
        }

        [Benchmark]

        public  void AddNumberInListUsingForeach()
        {
            foreach(int number in intList1)
            {
                intList3.Add(intList1[1]);
            }
        }
        


    }
}
