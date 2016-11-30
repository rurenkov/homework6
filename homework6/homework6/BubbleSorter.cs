using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
       public class BubbleSorter : Sorter
    {
        public BubbleSorter(int[] array) : base(array)
        {
        }
        
        public override void Sort()   // sorting logic
        {
            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[j - 1])
                    {
                        Swap(ref Array[j - 1], ref Array[j]);
                    }
                }
            }
        }




    }
}
