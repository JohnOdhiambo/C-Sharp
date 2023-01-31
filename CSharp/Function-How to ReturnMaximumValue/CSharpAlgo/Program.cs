using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgo
{
    class Program
    {
        static int findMaximum(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c || a == c)
                {
                    return a;
                }
            }
            if (b > c)
            {
                if (b > a || a == b)
                {
                    return b;
                }
            }

            return c;
        }
        static int findMaximum2(int a, int b, int c)
        {
            int max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            return max;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("The maximum value is", findMaximum2(5, 15, 20));
        }
    }
}
