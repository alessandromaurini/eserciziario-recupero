using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    internal class Program
    {
        // Scrivi un algoritmo che trova il numero massimo tra tre numeri interi.
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            Console.WriteLine("Scrivi 3 numeri interi");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if (n1 < 0 || n2 < 0 || n3 < 0)
            {
                Console.WriteLine("Scrivi solo numeri interi");
            }
            else if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"Il numero piu grande e' {n1}");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"Il numero piu grande e' {n2}");
            }
            else Console.WriteLine($"Il numero piu grande e' {n3}");
        }
    }
}
