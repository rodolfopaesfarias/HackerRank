using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;
            int y = 3;
            int z = 2;

            Console.WriteLine(catAndMouse(x,y,z));
            Console.ReadLine();
        }


        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            int catA = Math.Abs(x - z);
            int catB = Math.Abs(y - z);

            if (catA < catB)
            {
                return "Cat A";
            } else if (catB < catA)
            {
                return "Cat B";
            }
            return "Mouse C";
        }
    }
}
