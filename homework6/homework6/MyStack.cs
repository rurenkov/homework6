using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class MyStack:Buffer
    {
        public MyStack(int[] array) : base(array)
        {
        }
        private int top;


        //*******************************************************//
        // EMPTY stack;
        //*******************************************************//

        public override bool IsEmpty()
        {

            if (top == 0)
            {
                Console.WriteLine("stack is empty");

            }
            return true;
        }
        //*******************************************************//
        // is FULL  stack;
        //*******************************************************//

        public override bool IsFull()
        {

            if (top > Array.Length)
            {
                Console.WriteLine("Stack is full");
            }
            return true;
        }



        //*******************************************************//
        // push method;
        //*******************************************************//
        public void Push(int put)
        {

            if (top != Array.Length)
            {
                Array[top] = put;
                top++;
            }
            Console.WriteLine("top_push_" + top);         //debug

        }

        //*******************************************************//
        // pop method;
        //*******************************************************//
        public void Pop()
        {

            if (top > 0)
            {
                Array[top - 1] = 0;
                top--;
            }
            Console.WriteLine("top_pop_" + top);         //debug

        }
        //*******************************************************//
        // peek method;
        //*******************************************************//
        //need to fix
        public void Peek()
        {

            if (top > 0)
            {
                Array[top] = top;
            }

            Console.WriteLine("top_peek_" + top);  //debug

        }



    }
}
