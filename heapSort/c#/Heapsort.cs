using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Heapsort
    {
        //
        //Heap Sort Algorithm using max heap
        //Input: a  sequence of numbers
        //output: numbers in sorted sequence - ascending -
        //run-time :O(nlg(n))
        //
        
        static int[] A = { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
        static int heapsize = A.Length;
        
        static Boolean in_Range(int[] A, int i)
        {
            return (i < heapsize);
        }
        
        static int left(int i) { return (2 * i); }
        static int right(int i) { return (2 * i + 1); }
        static int parent(int i) { return i / 2; }
        
        static void max_Heapify(int[] A, int i)
        {
            int l = left(i);
            int r = right(i);
            int largest = i;

            if (in_Range(A, l) &&  A[i] < A[l]) // 'in_Range(A, r)'  useless because: 'largest < (heapsize/2)'
            {
                largest = l;
            }

            if (in_Range(A, r) && A[r] > A[largest])
            {
                largest = r;
            }

            if (i != largest)
            {
                exchange(i, largest);
                if (largest < heapsize / 2) // < or <=
                {
                    max_Heapify(A, largest);
                }
            }

        }
        
        static void build_Max_Heap(int[] A)
        {
            int len = A.Length /2;
            for (int j = len - 1; j >= 0; j--)
            {
                max_Heapify(A, j);
            }

        }
        
        static void heap_Sort(int[] A)
        {
            build_Max_Heap(A);
            for (int k = A.Length - 1; k >= 1; k--)
            {
                exchange(k, 0);
                heapsize--;
                max_Heapify(A, 0);
            }
        }
        
        static void exchange(int x, int y)
        {
            int temporary = A[x];
            A[x] = A[y];
            A[y] = temporary;
        }

        static void Main(string[] args)
        {
            WriteLine(A);
            heap_Sort(A);
            WriteLine(A);
            System.Threading.Thread.Sleep(5000);
        }

        public static void WriteLine(int[] A)
        {
            foreach (int item in A)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");
        }
    }
}
