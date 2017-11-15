using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmMergeSort
{
   public class TopDown
    {
        int[] A= new int[] { 7, 3, 2, 4, 5, 1, 9, 8 };
        int[] B;

        public void TopDownMergeSort(int n)
        {
            
            B = new int[n];
            CopyArray(0,n);
            TopDownSplitMerge(0,n);
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }

        public void TopDownSplitMerge(int iBegin,int iEnd)
        {
            if (iEnd - iBegin < 2) // if run size =1
                return;         // consider it sorted
            //split the run longer than 1 item into halves
            int iMiddle = (iEnd + iBegin) / 2;
            // recursively sort both runs from array A[] into B[]
            TopDownSplitMerge(iBegin,iMiddle);
            TopDownSplitMerge(iMiddle,iEnd);

            // merge the resulting runs from array B[] into A[]
            TopDownMerge(iBegin,iMiddle,iEnd);
        }

        //Left source half is A[iBegin:iMiddle-1]
        // Right source half is A[iMiddle:iEnd-1]
        //Result is ............B[iBegin:iEnd-1]
        public void TopDownMerge(int iBegin,int iMiddle,int iEnd)
        {
            int i = iBegin;
            int j = iMiddle;
            //While there are elements in the left or right runs...
            for (int k = iBegin; k < iEnd; k++)
            {
                //If left run head exists and is <=existing right run head
                if(i<iMiddle && (j>=iEnd || A[i] <= A[j]))
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
        public void CopyArray( int iBegin, int iEnd)
        {
            for (int i = iBegin; i < iEnd; i++)
            {
                B[i] = A[i];
            }

        }


    }
}
