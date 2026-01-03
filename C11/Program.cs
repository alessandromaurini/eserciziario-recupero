using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    internal class Program
    {
        // Scrivi un algoritmo che conta quanti multipli di 7 ci sono tra 1 e 100.
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                { 
                    n++;
                }
            }
            Console.WriteLine($"Tra 1 e 100 ci sono {n} multipli di 7");
        }
    }
}
