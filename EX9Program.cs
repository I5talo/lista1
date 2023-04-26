using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEX9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double a;

            Console.Write("Insira o valor do diâmetro: ");
            d = double.Parse(Console.ReadLine());
            a = 3.14 * (Math.Pow(d / 2, 2));
            Console.WriteLine("O valor da área de um círculo com um diâmetro de {0} é {1}" , d , a);




        }
    }
}
