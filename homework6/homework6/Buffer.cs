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
        public virtual bool IsFull()
        {
            return true;
        }
        //*******************************************************//
        // IS EMPTY method;
        //*******************************************************//
        public virtual bool IsEmpty()
        {

           return true;
        }

        public virtual void Print(int[] Array)
        {

            Console.WriteLine("[{0}]", string.Join(", ", Array));

        }

        public virtual void ParceD(ref int d)
        {
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Try again..");
            }
        }

    }
}
