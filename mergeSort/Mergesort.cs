using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MergeSort
{

    class Mergesort
    {
        public static void MergeSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                //double qf = Math.Floor((double)((p + r) / 2));
                int q = (p + r) / 2;
                MergeSort(A, p, q);
                MergeSort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }
        static void Merge(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1,
                n2 = r - q;

            int[] L = new int[n1+1],
                  R = new int[n2+1];

            int i = 0;
            for (; i < n1; i++)
            {
                    L[i] = A[p + i];

            }

            int j = 0;
            for (; j < n2; j++)
            {
                R[j] = A[q + j + 1];
            }

            L[n1] = 2147483647;
            R[n2] = 2147483647;

            i = 0;
            j = 0;
            int k = p;
            for (; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] A = {4, 5, 2, 1, 7, 3, 200, 6}; 
            foreach (var item in A)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");
            MergeSort(A ,0 ,A.Length - 1);
            foreach (var item in A)
            {
                Console.Write($"{item}\t");
            }
            Console.ReadKey();
        }
    }
}
