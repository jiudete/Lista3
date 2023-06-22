using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2;
            do
            {
                Console.WriteLine("Digite primeiro valor:");
                a1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite segundo valor:");
                a2 = double.Parse(Console.ReadLine());
                Console.Clear();
            } while (a2 > a1);
            Console.ReadKey();
        }
    }
}
