using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class AggregateAndFilter
    {
        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();


            foreach(int num in arr1)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            foreach(int num in arr2)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }
        //static void Main(string[] args)
        //{
        //    int[] arr1 = {-8, 2, 3, -9, 11, 20 };
        //    int[] arr2 = { 0, -2, -9, -39, 39, 10, 7 };

        //    int[] evenarray = FindEvenNums(arr1, arr2);
        //    Array.ForEach(evenarray, Console.WriteLine);
        //}
    }
}
