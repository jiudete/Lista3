using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, indice, a, maior, menor, soma;
            double negativos, positivos;
            indice = 0;
            maior = 0;
            menor = 0;
            soma = 0;
            negativos = 0;
            positivos = 0;
            Console.WriteLine("Digite a quantidade de números:");
            n = int.Parse(Console.ReadLine());
            while (n > 20 || n < 0)
            {
                Console.WriteLine("Valor fora do intervalo.");
                Console.WriteLine("Digite a quantidade de números:");
                n = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("Digite um número:");
                a = int.Parse(Console.ReadLine());
                indice = indice + 1;
                if (a > maior)
                {
                    maior = a;
                }
                if (a < menor)
                {
                    menor = a;
                }
                if (a < 0)
                {
                    negativos = negativos + 1;
                }
                if (a > 0)
                {
                    positivos = positivos + 1;
                }
                soma = soma + a;
            } while (indice < n);
            Console.WriteLine("O maior numero: " + maior);
            Console.WriteLine("O menor: " + menor);
            Console.WriteLine("A soma: " + soma);
            Console.WriteLine("Porcentagem de negativos: " + (negativos * n) / 100 + "%");
            Console.WriteLine("Porcentagem positivos: " + (positivos * n) / 100 + "%");
            Console.ReadKey();
        }
    }
}
