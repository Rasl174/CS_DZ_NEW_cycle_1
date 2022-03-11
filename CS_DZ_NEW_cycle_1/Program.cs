using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_cycle_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = 0;
            int threeDigitNumbers;

            for (int N = 1; N <= 27; N++)
            {
                threeDigitNumbers = N * N;

                if (threeDigitNumbers > 99 && threeDigitNumbers <= 999)
                {
                    countNumbers++;
                }
            }
            Console.WriteLine(countNumbers);
        }
    }
}
