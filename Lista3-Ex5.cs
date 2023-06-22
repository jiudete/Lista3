using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int indice = 1;
            do
            {
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 0);
            do
            {
                Console.WriteLine(numero + " x " + indice + " = " + numero * indice);
                indice = indice + 1;
            } while (indice <= 10);
            Console.ReadKey();
        }
    }
}
