using System;

class Program {
  public static void Main (string[] args) {
    int n1;
    int n2;
    int n3;
    int n4;
    int ma;
    Console.Write("Valor 1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Valor 2: ");
    n2 = int.Parse(Console.ReadLine());
    Console.Write("Valor 3: ");
    n3 = int.Parse(Console.ReadLine());
    Console.Write("Valor 4: ");
    n4 = int.Parse(Console.ReadLine());
    ma = (n1+n2+n3+n4)/4;
    Console.WriteLine("A média aritmética destes 4 valores é {0}", ma);
  }
}