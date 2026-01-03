using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace F49
{
    internal class Program
    {
        // Scrivi un programma che chiede l'anno di nascita di una persona e stampa la sua età attuale.
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il anno di nascita");
            int anno = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hai {Calcolo(anno)} anni");
        }

        static int Calcolo(int anno)
        {
            int eta;
            eta = 2026 - anno;
            return eta;
        }
    }
}
