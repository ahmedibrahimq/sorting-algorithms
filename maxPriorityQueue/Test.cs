using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQ
{
    class Test
    {
        static void Main(string[] args)
        {
            //int[] V = { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };
            //
            PriorityQueue Q = new PriorityQueue(new int[] { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 });
            Q.insert(500);
            Q.increase_Key(3, 50);
            var m = Q.Extract_Max();
        }
    }
}
