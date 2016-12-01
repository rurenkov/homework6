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

        public int tail;

    public override bool IsFull()
        {
            
            if (free <= 0)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;

        }



        public override bool IsEmpty()
        {

            if (free == Array.Length)
            {
                Console.WriteLine("QUEUE is empty");
            }
            return true;
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
            else if (IsFull())
            {

            }
        }
            //*******************************************************//
            // DEqueue method;
            //*******************************************************//

        public void Dequeue()

        {
            if (free < Array.Length)
            {
                if (tail < Array.Length)
                {
                    Array[tail] = 0;
                    tail++;
                }
                else if (tail == Array.Length)
                {
                    tail = 0;
                    Array[tail] = 0;
                    tail++;
                }
                free++;
                Console.WriteLine("tail__" + tail);         //debug
                Console.WriteLine("free__" + free);         //debug
            }
            else if (IsEmpty())
            {
            }
        }
    
    }
}