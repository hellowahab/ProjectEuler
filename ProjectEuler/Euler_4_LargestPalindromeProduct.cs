using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ProjectEuler
{
    public class Euler_4_LargestPalindromeProduct
    {
        public static long LargestPalindromeProduct(int firstNumber, int secondNumber)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long product = 0;
            long largestPalindrome = 0;
            string strProduct = "";
            bool isPalindrome = true;
            for (int i = firstNumber; i > 99; i--)
            {
                for (int j = secondNumber; j > 99; j--)
                {
                    product = i * j;
                    strProduct = product.ToString();
                    for (int k = 0; k < strProduct.Length; k++)
                    {
                        if (strProduct[k] != strProduct[strProduct.Length - 1 - k])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        isPalindrome = false;
                        if (product > largestPalindrome)
                        {
                            largestPalindrome = product;
                            Console.WriteLine(largestPalindrome);
                        }
                    }
                    else
                    {
                        isPalindrome = true;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Time elapsed while computing Largest Palindrome is:" + sw.ElapsedMilliseconds + " milli Seconds");
            return largestPalindrome;
        }
  
    }
}
