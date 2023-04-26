using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;
            
            Console.Write("Informe a base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe a altura: ");
            h = int.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine("O valora da área de um Retangulo de base {0} e altura {1} é {2}", b, h, a );
          
        }
    }
}
