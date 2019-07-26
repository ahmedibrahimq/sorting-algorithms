using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQ
{
    public class Heap
    {
        public int[] A;
        public int heapsize;
        public Heap(int[] A)
        {
            this.A = A;
            heapsize = this.A.Length - 1;
            build_Max_Heap();
        }
        
        Boolean in_HeapSize(int i)
        {
            return (i <= heapsize);
        }
        
        public int left(int i) { return (2 * i); }
        public int right(int i) { return (2 * i + 1); }
        public int parent(int i) { return i / 2; }
        
        public void max_Heapify(int i)
        {
            int l = left(i);
            int r = right(i);
            int largest = i;
            
            if (in_HeapSize(l) && A[i] < A[l])
                largest = l;
            
            if (in_HeapSize(r) && A[r] > A[largest])
                largest = r;
            
            if (i != largest)
            {
                exchange(i, largest);
                if (largest <= heapsize / 2)
                    max_Heapify(largest);
            }

        }
        
        public void build_Max_Heap()
        {
            int len = A.Length / 2;
            for (int j = len - 1; j >= 0; j--)
                max_Heapify(j);
        }
        
        public void heap_Sort()
        {
            build_Max_Heap();
            for (int k = A.Length - 1; k >= 1; k--)
            {
                exchange(k, 0);
                heapsize--;
                max_Heapify(0);
            }
        }
        
        public void exchange(int x, int y)
        {
            int temporary = A[x];
            A[x] = A[y];
            A[y] = temporary;
        }
    }
}
