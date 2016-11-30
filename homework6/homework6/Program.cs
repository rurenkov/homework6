using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,2,3,5,6};
            Sorter bubblesorter = new BubbleSorter(array);
            Sorter insertionSorter = new InsertionSorter(array);


        }
        public void GoToSortWithDiferentApproach( Sorter sorter) {

            sorter.Sort();
        }

    }
}
