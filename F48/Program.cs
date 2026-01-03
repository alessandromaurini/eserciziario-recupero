using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace F48
{
    internal class Program
    {
        // Crea un programma che simula una semplice calcolatrice con 4 operazioni base su due numeri.
        static void Main(string[] args)
        {
            int n1;
            int n2;
            string operazione;

            Inizio:
            Console.WriteLine("Ciao! Che tipo di operazione devi svolgere?");
            Console.WriteLine("+, -, /, *");
            string Operazione = Console.ReadLine();

            if (Operazione == "Addizione" || Operazione == "addizione" || Operazione == "+")
                operazione = "+";
            else if (Operazione == "Sottrazione" || Operazione == "sottrazione" || Operazione == "-")
                operazione = "-";
            else if (Operazione == "Divisione" || Operazione == "divisione" || Operazione == "/")
                operazione = "/";
            else if (Operazione == "Moltiplicazione" || Operazione == "moltiplicazione" || Operazione == "*")
                operazione = "*";
            else
            {
                Console.WriteLine("Non ho capito");
                goto Inizio;
            }

            Console.WriteLine("Scrivi i due numeri");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            switch (operazione)
            {
                case  "+":
                    Console.WriteLine($"Il risultato e' {Addizione(n1, n2)}");
                    break;
                case "-":
                    Console.WriteLine($"Il risultato e' {Sottrazione(n1, n2)}");
                    break;
                case "/":
                    Console.WriteLine($"Il risultato e' {Divisione(n1, n2)}");
                    break;
                case "*":
                    Console.WriteLine($"Il risultato e' {Moltiplicazione(n1, n2)}");
                    break;
                default:
                    break;
            }
        }
        static int Addizione(int n3, int n4)
        {
            int risultato = n3 + n4;
            return risultato;
        }
        static int Sottrazione(int n1, int n2)
        {
            int risultato = n1 - n2;
            return risultato;
        }
        static double Divisione(double n1, double n2)
        {
            double risultato = n1 / n2;
            return risultato;
        }
        static int Moltiplicazione(int n1, int n2)
        {
            int risultato = n1 * n2;
            return risultato;
        }
    }
}