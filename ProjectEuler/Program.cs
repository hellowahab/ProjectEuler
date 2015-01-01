using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples Of 3 And 5");
            Console.WriteLine(MultiplesOf3And5(1000));
            Console.WriteLine("Even Fibonacci Numbers");
            Console.WriteLine(EvenFibonacciNumbers(4000000));
            Console.WriteLine("Largest Prime Factor");
            Console.WriteLine(LargestPrimeFactor(600851475143));
            Console.WriteLine("Largest Palindrome Product");
            Console.WriteLine(LargestPalindromeProduct(999,999));
            Console.Read();
            //  Just a new changes
        }

        private static long MultiplesOf3And5(int limit)
        {
            long sum = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                    sum += i;
            }
            return sum;
        }

        private static long EvenFibonacciNumbers(long limit)
        {
            long firstNumber = 1;
            long SecondNumber = 2;
            long TransientNumber = 0;
            long EvenNumberSum = 0;
            while (TransientNumber + firstNumber < limit)
            {
                if (SecondNumber%2 == 0)
                    EvenNumberSum += SecondNumber;

                //Console.Write(SecondNumber + ", ");

                TransientNumber = firstNumber;
                firstNumber = SecondNumber;
                SecondNumber = TransientNumber + SecondNumber;
                
            }
            
            return EvenNumberSum;
        }

        private static long LargestPrimeFactor(long NumberToFactor)
        {
            long PrimeFactor = 2;
            while (NumberToFactor/PrimeFactor != 1)
            {
                if (NumberToFactor%PrimeFactor == 0)
                {
                    NumberToFactor = NumberToFactor/PrimeFactor;
                    Console.WriteLine(PrimeFactor);
                }

                PrimeFactor++;

            }
            return NumberToFactor;


        }

        private static long LargestPalindromeProduct(int firstNumber, int secondNumber)
        {
            long product = 0;
            string strProduct = "";
            bool isPalindrome = true;
            for (int i = firstNumber; i > 99; i--)
            {
                for (int j = secondNumber; j > 99; j--)
                {
                    product = i*j;
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
                        Console.WriteLine(i + "*" + j);
                        return product;
                    }
                    else
                    {
                        isPalindrome = true;
                    }
                }
            }
            return product;
        }
    }
}
