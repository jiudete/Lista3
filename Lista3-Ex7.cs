using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int indice = 1;
            do
            {
                do
                {
                    Console.WriteLine(numero + " x " + indice + " = " + numero * indice);
                    indice = indice + 1;
                } while (indice <= 10);
                Console.WriteLine("Pressione alguma tecla");
                Console.ReadKey();
                indice = 1;
                numero = numero + 1;
            } while (numero <= 20);
            Console.ReadKey();
        }
    }
}
