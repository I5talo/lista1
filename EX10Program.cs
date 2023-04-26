using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cd;
            double d;
            double r;

            Console.Write("Insira a quatidade de dolares a serem cambiados: ");
            d=double.Parse(Console.ReadLine());
            cd = 4.94;
            Console.WriteLine("Cotação do dolar: {0} reais",cd);
            r = d * cd;
            Console.WriteLine("{0} dolares correspondem a {1} reais",d,r);


        }
    }
}
