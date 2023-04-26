using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1___EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;

            Console.Write("valor da base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("valor da altura: ");
            h = int.Parse(Console.ReadLine());
            a = b * h / 2;
            Console.WriteLine("O valor da área de um triangulo de base {0} e altura {1} é {2}", b, h, a);

         

        }
    }
}
