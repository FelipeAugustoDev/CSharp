using System;
namespace Projetos
{
  public class Program
  {
    static void Main(string[] args)
    {

      string[] Peca = { "macacao", "blusa", "calcinha" };
      double[] Preco = { 11.21, 10.99, 13.15 };
      double[] Tamanho = { 10, 9, 23 };
      double soma = 0;
      int ItemMenor = 0;
      int ItemMaior = 0;


      if (Peca.Length != Tamanho.Length || Peca.Length != Preco.Length) return;


      for (int i = 0; i < Peca.Length; i++)
      {
        Console.WriteLine("Item: " + Peca[i]);
        Console.WriteLine("Preco: " + Preco[i]);
        Console.WriteLine("Tamanho: " + Tamanho[i]);
        Console.WriteLine("--------------**--------------");
        soma += Preco[i];

      }

      for (int j = 0; j < Peca.Length; j++)
      {
        Console.WriteLine(Peca[j]);

        if (Tamanho[j] < 10)
        {
          ItemMenor++;

          Console.WriteLine("quantidade de itens MENORES: " + ItemMenor);
          Console.WriteLine("e o preco do item menor é de: " + Preco[j]);
          Console.WriteLine("----------------------------");
        }
        else
        {
          ItemMaior++;

          Console.WriteLine("quantidade de itens MAIORES: " + ItemMaior);
          Console.WriteLine("e o preco  total maior com acrescimo de 20% é de: " + (Preco[j] + (Preco[j] * 0.2)));
          Console.WriteLine("----------------------------");
        }

      }
      Console.WriteLine("Preco total: " + soma);
      Console.ReadKey();

      //ATIVIDADE RECUPERACAO NMR 3
    }
  }
}