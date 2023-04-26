using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1___EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double a;
            Console.Write("Valor da diagonal do quadrado: ");
            d = double.Parse(Console.ReadLine());
            a = Math.Pow(d, 2) / 2;
            Console.WriteLine("Valor da área baseado em sua diagonal é: {0}", a);
            
            
             
        }
    }
}
