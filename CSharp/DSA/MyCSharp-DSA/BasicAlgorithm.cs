using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class BasicAlgorithm
    {
        public int findMaximum2(int a, int b, int c)
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
        static void Main(string[] args)
        {
            BasicAlgorithm ba = new BasicAlgorithm();
            int result = ba.findMaximum2(20,4,13);
            Console.WriteLine("The maximum number is " + result);
        }

    }
}
