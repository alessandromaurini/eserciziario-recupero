using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C32
{
    internal class Program
    {
        // Crea un ciclo che legge interi positivi e stampa il massimo trovato finché non viene inserito un numero negativo.
        static void Main(string[] args)
        {
            int n;
            int nmax = 0;
            Console.WriteLine("Scrivi un numero");
            do
            {
                n = int.Parse(Console.ReadLine());
                if(n > nmax)
                    nmax = n;
            }
            while (n > 0);
            Console.WriteLine($"il numero piu grande e' {nmax}");
        }
    }
}
