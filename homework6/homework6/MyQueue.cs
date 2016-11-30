using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyQueue : Buffer
    {

        public MyQueue(int[] array) : base(array)
        {
        }
          

        //*******************************************************//
        // enqueue method;
        //*******************************************************//
        public void Enqueue(int put)
        {
            if (free > 0)
            {
                if (head < Array.Length)
                {
                    Array[head] = put;
                    head++;
                }
                else if (head == Array.Length)
                {
                    head = 0;
                    Array[head] = put;
                    head++;
                }
                free--;
                Console.WriteLine("free__" + free);         //debug
                Console.WriteLine("tail__" + tail);         //debug
            }
            else if (MyQueue.IsFull(free))
            {

            }
        }
    }
}