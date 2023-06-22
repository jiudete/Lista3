using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, indice;
            indice = 1;
            a = 0;
            b = 1;
            Console.Write("A sequencia é: 1, ");
            do
            {
                c = a + b;
                Console.Write(c + ", ");
                a = b;
                b = c;
                indice = indice + 1;
            }
            while (indice <= 30);
            Console.ReadKey();
        }
    }
}
