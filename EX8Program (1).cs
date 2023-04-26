using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            double f;

            Console.Write("Valor da temperatura em Celsius: ");
            c=double.Parse(Console.ReadLine());
            f = (c * 1.8) + 32;
            Console.WriteLine("O valor de {0} graus Celcius em Fahrenheit é: {1}", c, f);

        }
    }
}
