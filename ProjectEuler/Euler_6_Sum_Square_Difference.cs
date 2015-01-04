/* Sum Square Difference
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Euler_6_Sum_Square_Difference
    {
        public static long Sum_Square_Difference(int StartingNumber, int EndingNumber)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long sumOfSquare = 0;
            long squareOfSum = 0;
            for (int i = StartingNumber; i <= EndingNumber; i++)
            {
                sumOfSquare += i*i;
                squareOfSum += i;
            }
            sw.Stop();
            Console.WriteLine("Time elapsed while computing Sum Square Difference is:" + sw.ElapsedMilliseconds + " milli Seconds");
            return squareOfSum*squareOfSum - sumOfSquare;
        }
    }
}
