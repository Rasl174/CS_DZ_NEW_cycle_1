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
            int N;

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        N = i + j + k;

                        if (N >= 1 && N <= 27)
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
