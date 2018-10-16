using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorting
    {
       

        static void Swap(int[] A, int i, int j)
        {
            var temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

       
        static int Partition(int[] A, int p, int r)
        {
            var x = A[p];
            int i = p;
            for (int j = p + 1; j < r + 1; j++)
            {
                if (A[j] <= x)
                {
                    i++;
                    Swap(A, i, j);
                }
            }
            Swap(A, p, i);
            return i;
        }

        static void QuickSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(A, p, r);
                QuickSort(A, p, q - 1);
                QuickSort(A, q + 1, r);
            }
        }
    }
}