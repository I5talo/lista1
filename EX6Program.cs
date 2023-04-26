using System;

class Program {
  public static void Main (string[] args) {
    double n1;
    double n2;
    double mg;
    Console.Write("Valor 1: ");
    n1 = double.Parse(Console.ReadLine());
    Console.Write("Valor 2: ");
    n2 = double.Parse(Console.ReadLine());
    mg = Math.Sqrt(n1*n2);
    Console.WriteLine("A média geométrica destes 2 valores é {0}", mg);
  }
}