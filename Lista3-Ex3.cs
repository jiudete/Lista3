using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            do
            {
                Console.WriteLine("Entre com gênero:");
                Console.WriteLine("M - Masculino.");
                Console.WriteLine("F - Feminino.");
                sexo = Console.ReadLine();
                if (sexo != "M" && sexo != "F")
                {
                    Console.WriteLine("Gênero não reconhecido!");
                }
            } while (sexo != "F" && sexo != "M");
            Console.ReadKey();
        }
    }
}
