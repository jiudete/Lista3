using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            a = 1;
            soma = 0;
            do
            {
                b = a + 1;
                soma = soma + a + b;
                a = b + 1;
            } while (a < 100);
            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();
        }
    }
}
