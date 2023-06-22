using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int número;
            número = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("5 x " + número + " = " + (5 * número));
                número = número + 1;
            } while (número <= 10);
            Console.ReadKey();
        }
    }
}
