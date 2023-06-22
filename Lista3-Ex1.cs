using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Digite um número:");
            n = double.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Número positivo.");
            }
            Console.ReadKey();
        }
    }
}
