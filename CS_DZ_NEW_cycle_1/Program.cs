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
            int intervalNumbers;
            int IntervalStart = 1;
            int IntervalEnd = 27;
            int countSingleNumbers = 9;

            for (int i = 1; i <= countSingleNumbers; i++)
            {
                for (int j = 0; j <= countSingleNumbers; j++)
                {
                    for (int k = 0; k <= countSingleNumbers; k++)
                    {
                        intervalNumbers = i + j + k;

                        if (intervalNumbers >= IntervalStart && intervalNumbers <= IntervalEnd)
                        {
                            countNumbers++;
                        }
                    }
                }
            }
            Console.WriteLine(countNumbers);
        }
    }
}
