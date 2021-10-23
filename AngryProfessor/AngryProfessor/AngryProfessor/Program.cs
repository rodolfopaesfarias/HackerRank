using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            List<int> a = new List<int> { -1, -3, 4, 2 };
            Console.WriteLine(angryProfessor(k, a));
            k = 2;
            a = new List<int> { 0, -1, 2, 1 };
            Console.WriteLine(angryProfessor(k, a));
            Console.ReadLine();
        }

        public static string angryProfessor(int k, List<int> a)
        {
            int onTime = a.Count(h => h <= 0);
            return onTime >= k ? "NO" : "YES";
        }
    }
}
