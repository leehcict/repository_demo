using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmMergeSort
{
    public class Fibonacci
    {
        public int Fibonaccis(int n)
        {
            int a = 0;
            int b = 1;
            int next = 0;
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = a + b;
                    a = b;
                    b = next;
                }
            }
            return next;
        }
        public int SumFibonacci(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Fibonaccis(n);
            }
            return sum;
        }
    }
}
