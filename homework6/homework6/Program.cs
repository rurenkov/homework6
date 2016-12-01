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
            //
            //*******************************************************//
            // BuBBLE SORT
            //*******************************************************//

            Console.WriteLine("************************");
            Console.WriteLine("******buble************");

            int[] array1 = new int[] { 5, 4, 1, 9, 1 };

            //BubbleSorter bubbleSorter = new BubbleSorter(array1);  ///создаем нову переменну bubbleSorter з типом ВubbleSorter 
            Sorter sorter = new Sorter(array1);  ///создаем нову переменну bubbleSorter з типом ВubbleSorter 
            BubbleSorter bubblesorter = new BubbleSorter(array1);  ///создаем нову переменну bubbleSorter з типом ВubbleSorter 


            bubblesorter.Print(array1);
            bubblesorter.Sort();    // визов метода Sort,з класса бабл сортер, передача йому значень масива для сортування.
                                    // він приймає значення, біжить по коду і результат друкуєм в тілі програми.
            sorter.Print(array1);


            //*******************************************************//
            // INSERTING SORT
            //*******************************************************//

            Console.WriteLine("************************");
            Console.WriteLine("******insert************");
            int[] array2 = new int[] { 9, 6, 3, 1, 4 };
            InsertionSorter insertionsorter = new InsertionSorter(array2);
            sorter.Print(array2);
            insertionsorter.Sort();
            sorter.Print(array2);

            //*******************************************************//
            // Stack
            //*******************************************************//

            int add = 0;
            Console.WriteLine("************************");
            Console.WriteLine("******My Stack************");
            int[] array3 = new int[] { 0, 0, 0, 0, 0 };

            Buffer buffer = new Buffer(array3);
            MyStack mystack = new MyStack(array3);


            buffer.Print(array3);
            add = 789;                  // debug value
            mystack.Push(add);
            buffer.Print(array3);
            mystack.Peek();
            mystack.Pop();

            //*******************************************************//
            // CIrcular Q
            //*******************************************************//


            int Buffsize = 0;
            int put = 0;
            int free1 = 1;
            int choise = 0;

            Console.WriteLine("Enter the size of an stack");
            buffer.ParceD(ref Buffsize);            // parce size of stack
            int[] array4 = new int[Buffsize];      // define stack
            buffer.Print(array4);

            MyQueue myqueue = new MyQueue(array4);

            while (free1 > 0)
            {
                Console.WriteLine("To add value press :1, to delete value press :2, to exit press: 3 \n");

                buffer.ParceD(ref choise);
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter what you want to add \n");
                        buffer.ParceD(ref put);                     //parce value which needs to be added
                        myqueue.Enqueue(put);
                        buffer.Print(array4);
                        break;

                    case 2:

                        myqueue.Dequeue();
                        buffer.Print(array4);

                        break;
                    case 3:

                        {
                            free1 = 0;

                        }
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
