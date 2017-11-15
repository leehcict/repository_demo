using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmMergeSort
{
    public class BottomUp
    {
        int[] A= { 20,10,1,3,4,6,2,9,7,8,5,11};
        int[] B;
        public void BottomUpMergeSort(int n)
        {
           B = new int[n];
            //Each 1-element run in A is already "sorted";
            //Make successively longer sorted runs of lenght 2,4,8,16... until whole array is sorted
            for (int w = 1; w < n; w=2*w)
            {
                //Array A is full of runs of length width
                for (int i = 0; i < n; i=i+2*w)
                {
                    BottomUpMerge(i,Math.Min(i+w,n),Math.Min(i+2*w,n));
                }

                CopyArray(n);
            }
            for(int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            
        }

        public void BottomUpMerge(int iLeft,int iRight,int iEnd)
        {
            int i = iLeft;
            int j = iRight;
            //while there are elements in the left or right runs
            for (int k = iLeft; k < iEnd; k++)
            {
                //if left run head exists and is <= existing right run head
                if(i<iRight && (j>=iEnd || A[i]<=A[j]))
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
            }
        }

        public void CopyArray(int n)
        {
            for(int i = 0; i < n; i++)
            {
                A[i] = B[i];
            }
        }
    }
}
