using System;
using System.Collections.Generic;
using System.Text;

namespace uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            int N;
            int sedlar = 0;
            Console.WriteLine("Priset: ");
            N = int.Parse(Console.ReadLine());

            string high = "111111111";
            int highint = int.Parse(high);

            while(!stop)
            {
                if (N - highint < 0)
                {
                    high = high.Remove(0, 1);
                    highint = int.Parse(high);
                }
                else if (N - highint >= 0)
                {
                    N = N - highint;
                    sedlar++;
                }


                if (N == 0)
                {
                    stop = true;
                }

            }

            Console.WriteLine("Antal sedlar: " + sedlar);
            Console.ReadKey();

        }
    }
}
