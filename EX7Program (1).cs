using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mlh;
            double km;

            Console.Write("insira o valor de milhas:");
            mlh = double.Parse(Console.ReadLine());
            km = (mlh * 1852) / 1000;
            Console.WriteLine("O valor em quilômetros de {0} milhas marítimas é: {1} km", mlh, km);
        }
    }
}
