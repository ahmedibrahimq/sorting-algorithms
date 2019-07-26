using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQ
{
    public class PriorityQueue :Heap
    {
        public PriorityQueue(int[] A): base(A) { }
        
        public int Maximum()
        {
            return A[0];
        }
        
        public int Extract_Max()
        {
            int max = A[0];
            A[0] = A[heapsize];
            heapsize--;
            max_Heapify(0);
            return max;
        }
        
        public void increase_Key(int i, int key)
        {
            if (key > A[i])
                A[i] = key;
            //
            while (i > 0 && A[i] > A[parent(i)])
            {
                exchange(i, parent(i));
                i = parent(i);
            }
        }
        
        public void insert(int key)
        {
            heapsize++;
            
            inc_HeapSize();
            
            A[heapsize] = int.MinValue;
            increase_Key(heapsize, key);
        }
        
        public void inc_HeapSize()
        {
            var tmp = A;
            A = new int[heapsize + 1];
            for (int i = 0; i < heapsize; i++)
                A[i] = tmp[i];
            
        }
    }

}
