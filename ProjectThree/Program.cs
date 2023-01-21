using System;
namespace Projetos
{
  public class Program
  {
    static void Main(string[] args)
    {
      int soma = 0;
      int qtd = 0;


      int[] vetor = { 13, 5, 10 };
      string[] produto = { "agua", "laranja", "morango" };

      int n = 1;

      if (produto.Length != vetor.Length) return;
      for (int i = 0; i < vetor.Length; i++)
      {
        Console.WriteLine("O produto na posicao " + n + " é: " + produto[i]);
        n++;
      }

      foreach (int item in vetor)
      {
        soma += item;
        qtd++;
        Console.WriteLine("Quantidade total de produtos: " + qtd + " e preço total até o momento: " + soma);

      }


      Console.ReadKey();
    }
  }
}