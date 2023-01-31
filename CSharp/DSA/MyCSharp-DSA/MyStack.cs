using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    //Push adds to the top of the stack
    //pop removes from the top of the stack
    //Stack follows LIFO 
    class MyStack
    {
        static void printNextGreaterElement(int [] arr)
        {
            //In order to print items, the array must have items
            if(arr.Length <= 0)
            {
                Console.WriteLine();
                return;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);
            //Check if each element in the array is the next bigger element
            for(int i = 1;i < arr.Length; i++)
            {
                int next = arr[i];
                if(stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while(popped < next)
                    {
                        Console.WriteLine(popped + "-->" + next);
                        if(stack.Count == 0)//if stack is empty break the loop
                        {
                            break;
                        }
                        popped = stack.Pop();
                    }
                    if(popped  > next)
                    {
                        stack.Push(popped);
                    }
                }
                //if stack has no items we push onto the next stack
                stack.Push(next);
            }
            //By this point, all items with a greater element have been printed
            //items that do not have a greater element need to be reassigned to -1
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "-->" + -1);
            }

        }
        //static void Main(string[] args)
        //{
        //    Stack<string> stack = new Stack<string>();

        //    Console.WriteLine("Start Main");
        //    stack.Push("Main");//Starts with the main method
        //    Console.WriteLine("Start ResponseBuilder");
        //    stack.Push("ResponseBuilder");
        //    Console.WriteLine("Start CallExternalService");
        //    stack.Push("CallExternalService");
        //    Console.WriteLine("END" + stack.Pop());
        //    Console.WriteLine("Start ParseExternalData");
        //    stack.Push("ParseExternalData");
        //    Console.WriteLine("END" + stack.Pop());
        //    Console.WriteLine("END" + stack.Pop());
        //    Console.WriteLine("END" + stack.Pop());


        //    int[] arr = new int[] {15, 8, 4, 10 };
        //    int[] arr2 = new int[] { 2 };
        //    int[] arr3 = new int[] { 2, 3 };
        //    int[] arr4 = new int[] { };

        //    printNextGreaterElement(arr);
        //    printNextGreaterElement(arr2);
        //    printNextGreaterElement(arr3);
        //    printNextGreaterElement(arr4);
        //}

    }
}
