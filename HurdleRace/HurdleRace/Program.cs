using System;
using System.Collections.Generic;
using System.Linq;

namespace HurdleRace
{
    class Program
    {

        static void Main(string[] args)
        {
            int k = 4;
            List<int> height = new List<int> { 1, 6, 3, 5, 2 };
            Console.WriteLine(hurdleRace(k, height));

            k = 7;
            height = new List<int> { 2, 5, 4, 5, 2 };
            Console.WriteLine(hurdleRace(k, height));

            Console.ReadKey();
        }

        public static int hurdleRace(int k, List<int> height)
        {
            int maxHeight = height.Max();
            int potions = maxHeight - k;
            if (potions < 0) potions = 0;
            return potions;
        }
    }
}
