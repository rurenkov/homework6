using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
  public class Buffer
    {

        public int[] Array;
        public int head;

        public int free;
        
        public int put;

        public Buffer(int[] array)
        {
            this.Array = array;
            this.free = 0;
            this.head = 0;
            this.free = Array.Length - head;
        }



        //*******************************************************//
        // IS FULL method;
        //*******************************************************//
        public static bool IsFull(int free)
        {

            if (free <= 0)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;
        }
        //*******************************************************//
        // IS EMPTY method;
        //*******************************************************//
        public static bool IsEmpty(int free, int Buffsize)
        {

            if (free == Buffsize)
            {
                Console.WriteLine("QUEUE is empty");
            }
            return true;
        }

        public static void Print(int[] Array)
        {

            Console.WriteLine("[{0}]", string.Join(", ", Array));

        }

    }
}
