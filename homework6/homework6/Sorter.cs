using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class Sorter
    {
        public int[] Array;

        public Sorter(int[] array)
        {
            this.Array = array;
        }


        public  void Print(int[] MyArray)
        {

            Console.WriteLine("[{0}]", string.Join(", ", MyArray));

        }

        public  void Swap(ref int a, ref int b)   // need to fix it in order to work with indexes.

        {
            int tmp = 0;
            tmp = a;
            a = b;
            b = tmp;
        }

        public virtual void Sort()   // sorting logic
        {
         
        }
               


    }
}
