using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class LinearAndBinarySearch
    {
        //Sequential search where we consider each item in an array
        static Boolean LinearSearch(int[] input, int n)
        {
            foreach(int current in input)
            {
                if(n == current)
                {
                    return true;
                }
            }

            return false;
        }
        static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                //if item is equal to item we looking for
                if(item == inputArray[mid])
                {
                    return true;
                }
                //if item is less than item at mid point
                else if(item < inputArray[mid])
                {
                    max = mid - 1;
                }
                //it two conditions are false then item must be greater than item at mid point
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(LinearSearch(arr, 4));
            Console.WriteLine(LinearSearch(arr, 8));

            int item = Array.Find(arr, element => element == 3);
            Console.WriteLine(item);
            int[] items = Array.FindAll(arr, element => element >= 5);
            Array.ForEach(items, Console.WriteLine);

            Console.WriteLine(BinarySearch(arr, 3));

        }
    }
}
