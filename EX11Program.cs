using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double r;
            Console.Write("Insira o valor de x:");
            x=double.Parse(Console.ReadLine());
            Console.Write("Insira o valor de y:");
            y=double.Parse(Console.ReadLine());
            r = Math.Pow(x, y);
            Console.WriteLine("O valor de x({0}) elevado a y({1}) é {2}", x, y, r);

        }
    }
}
