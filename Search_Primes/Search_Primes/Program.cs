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

            Console.WriteLine(7%4);

            for (int i = 1; i < n; i++)
            {
                t = i;
                temp = 1;

                for (int j = 1; j < i; j++)
                {
                    if (i%j != 0)
                        temp++;


                }

                if (temp == i)
                    Console.WriteLine(t);

            }


        }
    }
}
