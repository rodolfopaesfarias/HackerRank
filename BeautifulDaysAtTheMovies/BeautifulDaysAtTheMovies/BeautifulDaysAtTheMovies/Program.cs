using System;
using System.Diagnostics;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var cron = new Stopwatch();
            cron.Start();
            //1 2000000 23047885
            int i = 1;
            int j = 2000000;
            int k = 23047885;
            Console.WriteLine(beautifulDays(i, j, k));
            cron.Stop();
            Console.WriteLine(cron.Elapsed.ToString());
            Console.ReadLine();
        }

        public static int beautifulDays(int i, int j, int k)
        {
            int beautifulDays = 0;
            for (int c = i; c <= j; c++)
            {
                int dif = c - getReverse(c);                
                if (dif % k == 0) beautifulDays++;

            }
            return beautifulDays;
        }

        private static int getReverse(int c)
        {
            int reverse = 0;
            while (c > 0)
            {
                reverse = reverse * 10 + c % 10;
                c /= 10;
            }
            return reverse;
        }
    }
}
