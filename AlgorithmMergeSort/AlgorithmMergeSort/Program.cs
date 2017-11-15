using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmMergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            TopDown td = new TopDown();
            td.TopDownMergeSort(8);
            Console.WriteLine("----------------// -------------");
            BottomUp bb = new BottomUp();
            bb.BottomUpMergeSort(12);
            Console.WriteLine("----------------/Finbonacci/----------");

            int f = new Fibonacci().SumFibonacci(4);
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
