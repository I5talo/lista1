using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1___EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aresta;
            double a;
            Console.Write(" Digite o valor da aresta: ");
            aresta = double.Parse(Console.ReadLine());
            a = Math.Pow (aresta, 2);
            Console.WriteLine("o valor da area do quadrado baseado em sua aresta {0} é {1}", aresta, a);
        }
    }
}
