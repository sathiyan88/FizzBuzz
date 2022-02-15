using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// FFX- Assignment 
/// FizzBuzz
/// Developer: S.Sathiyan 15-02-2022
/// </summary>
namespace FFX_FizzBuzz
{
    public static class FizzBuzz
    {
        public static void Main(string[] args)
        {
            RunFizzBuzz(100); // Call the Method 
            Console.ReadKey();
        }

        /// <summary>
        /// Define Algorithams 
        /// call RunFizzBuzz method 
        /// </summary>
        /// <param name="maxVal"></param>
        public static void RunFizzBuzz(int maxVal)
        {
            for (int i = 1; i <= maxVal; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
