using System;
namespace Projetos
{
  public class Program
  {
    static void Main(string[] args)
    {
      //SÓ CRIAR UM READLINE PARA RECEBER VALOR DO VETORKK 
      string[] nomeProduto = { "p1", "p2", "p3", "p1" };
      double[] precoProduto = { 10, 32, 15, 10 };

      int p1 = 0;
      int p2 = 0;
      int p3 = 0;
      int qtd = 0;
      double soma = 0;
      double resultado = 0;

      if (nomeProduto.Length != precoProduto.Length) return;

      for (int i = 0; i < precoProduto.Length; i++)
      {

        Console.WriteLine("O Produto: " + nomeProduto[i] + " tem o preço de: " + precoProduto[i]);
        if (nomeProduto[i] == "p1") { p1++; }
        else if (nomeProduto[i] == "p2") { p2++; }
        else { p3++; }
        soma += precoProduto[i];
      }
      Console.WriteLine("Qnt de p1: " + p1);
      Console.WriteLine("Qnt de p2: " + p2);
      Console.WriteLine("Qnt de p3: " + p3);
      resultado = soma / precoProduto.Length; //média


      Console.WriteLine(resultado);
      Console.ReadKey();

      //ATIVIDADE RECUPERACAO NMR 1
    }
  }
}