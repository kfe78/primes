using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int n = 1000;
            int t;

            for (int i = 2; i < n; i++)
            {
                t = i;
                temp = 2;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                    else
                        temp++;

                }

                if (temp == i)
                    Console.WriteLine(t);

            }


        }
    }
}
