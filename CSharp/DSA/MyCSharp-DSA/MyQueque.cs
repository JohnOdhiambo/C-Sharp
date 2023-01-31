using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    //Data structure where you need to process data in order;it contains an element in the order they were added
    //Elements are inserted at the end and removed from the front;FIFO
    //enqueue, dequeue and peek to access an item
    class MyQueque
    {
        static void printBinary(int n)
        {
            if(n <= 0)
            {
                return;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for (int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 0);
                queue.Enqueue(current * 10 + 1);
            }

            Console.WriteLine();
        }
        //static void Main(string[] args)
        //{
        //    //Create a queque using a queue constructor; it will contain integers
        //    Queue<int> queque = new Queue<int>();

        //    queque.Enqueue(1);
        //    queque.Enqueue(8);
        //    queque.Enqueue(20);
        //    queque.Enqueue(23);

        //    //saved the removed number with a variable
        //    int removeditem = queque.Dequeue();
        //    Console.WriteLine(removeditem);
        //    Console.WriteLine(queque.Dequeue());//remove the next item on the queue
        //    Console.WriteLine(queque.Peek());//to access the next to be removed on the queue

        //    Console.WriteLine(queque.Dequeue());
        //    //To iterate through a queue
        //    //int current;//variable to save dequeued item
        //    //while (queque.TryDequeue(out current))
        //    //{
        //    //    Console.WriteLine(current);
        //    //}
        //    Console.WriteLine();
        //    printBinary(5);
        //    printBinary(-2);
        //    printBinary(0);
        //    printBinary(2);
        //    printBinary(8);
        //}

    }
}
