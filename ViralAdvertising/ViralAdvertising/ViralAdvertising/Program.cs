using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(viralAdvertising(3));
            Console.ReadLine();
        }

        public static int viralAdvertising(int n)
        {
            int totalLikes = 0;
            int shared = 5;
            for (int d = 1; d <= n; d++)
            {
               int  dayLikes = (int)Math.Floor((double)shared / 2);
                shared = dayLikes * 3;
                totalLikes += dayLikes;
            }
            return totalLikes;
        }

    }
}
