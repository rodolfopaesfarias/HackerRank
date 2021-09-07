using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(utopianTree(0));
            Console.WriteLine(utopianTree(1));
            Console.WriteLine(utopianTree(4));
            Console.ReadLine();
        }

        public static int utopianTree(int n)
        {
            int height = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0) 
                {
                    height *= 2;
                }  else
                {
                    height++;
                }
            }
            return height;
        }
    }
}
