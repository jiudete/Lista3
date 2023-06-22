using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, indice, maior;
            double soma, média;
            soma = 0;
            indice = 0;
            maior = 0;
            do
            {
                Console.WriteLine("Digite o valor:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor:");
                b = int.Parse(Console.ReadLine());
                if (a > b && a > maior)
                {
                    maior = a;
                }
                if (b > a && b > maior)
                {
                    maior = b;
                }
                indice += 1;
                soma = soma + a + b;
            } while (indice < 5);
            Console.WriteLine("O maior é: " + maior);
            Console.WriteLine("A soma é: " + soma);
            média = soma / 10;
            Console.WriteLine("Média aritimética é: " + média);
            Console.ReadKey();
        }
    }
}
