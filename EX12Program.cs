using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double p3;
            double p4;
            double p5;
            double to;
            double pG;
            double tr;

            Console.Write("Insira o valor do produto 1: ");
            p1= double.Parse(Console.ReadLine());
            Console.Write("Insira o valor do produto 2: ");
            p2 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor do produto 3: ");
            p3 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor do produto 4: ");
            p4 = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor do produto 5: ");
            p5 = double.Parse(Console.ReadLine());
            to=p1+p2+p3+p4+p5;
            Console.WriteLine("O valor total da sua compra é:{0}",to);
            Console.Write("Insira o valor do pagamento:");
            pG= double.Parse(Console.ReadLine());
            tr=pG-to;
            Console.WriteLine("O seu troco é de {0} reais",tr);
        }
    }
}
