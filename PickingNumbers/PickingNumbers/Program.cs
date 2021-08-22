using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2, 98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1, 4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99, 9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4 };
            Console.WriteLine(pickingNumbers(a));
            List<int> b = new List<int> { 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66 };
            Console.WriteLine(pickingNumbers(b));
            Console.ReadLine();
        }

        public static int pickingNumbers(List<int> a)
        {
            Dictionary<int, int> lengthByItem = new Dictionary<int, int>();
            for (int i = 0; i < a.Count; i++)
            {
                lengthByItem.Add(i, 1);
                int min = a[i];
                int max = a[i];
                bool foundDif = false;

                for (int z = 0; z < a.Count; z++)
                {
                    if (z == i) continue;

                    if (!foundDif)
                    {
                        int dif = a[i] - a[z];

                        if (Math.Abs(dif) <= 1)
                        {
                            lengthByItem[i]++;
                            if (dif != 0)
                            {
                                min = Math.Min(a[i], a[z]);
                                max = Math.Max(a[i], a[z]);
                                foundDif = true;
                            }
                        }
                    }
                    else
                    {
                        if (a[z] >= min && a[z] <= max) lengthByItem[i]++;
                    }

                }
            }

            return lengthByItem.Values.Max();
        }
    }
}
