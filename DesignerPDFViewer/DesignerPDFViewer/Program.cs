using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> h = new List<int> { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            string word = "zaba";
            Console.WriteLine(designerPdfViewer(h, word));
            Console.ReadLine();
        }

        public static int designerPdfViewer(List<int> h, string word)
        {
            var letras = word.Distinct();
            int alturaMaxima = 0;
            foreach (char letra in letras)
            {
                int altura = h[(int)letra - 97];
                alturaMaxima = Math.Max(altura, alturaMaxima);
            }
            return alturaMaxima * word.Length;
        }

    }
}
