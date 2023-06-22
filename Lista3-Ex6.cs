using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;
            do
            {
                Console.WriteLine("Digite um número");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(" Digite o menor limite");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o maior limite");
                b = int.Parse(Console.ReadLine());
                if (b < a)
                {
                    Console.WriteLine("digite novamente o intervalo ");
                }
            } while (b < a);
            do
            {
                Console.WriteLine(x + " x " + b + " = " + x * b);
                b = b - 1;
            } while (b >= a);
            Console.ReadKey();
        }
    }
}
