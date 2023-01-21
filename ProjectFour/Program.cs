using System;
namespace Projetos
{
  public class Program
  {
    static void Main(string[] args)
    {
      string[] sexo = { "homem", "mulher", "trans" };
      string[] funcionario = { "marcos", "raquel", "lilia" };
      int[] idade = { 18, 30, 27 };
      double mediaPorc = 0;

      int[] numFic = { 2000, 1300, 1500 };// aqui seria o valor fictício
      if (funcionario.Length != idade.Length) return;
      for (int i = 0; i < funcionario.Length; i++)
      {
        Console.WriteLine(sexo[i]);
        Console.WriteLine(funcionario[i]);
        Console.WriteLine(idade[i]);
        Console.WriteLine("------------------------------------");



        mediaPorc = (numFic[i] * 0.3);


        Console.WriteLine(" o funcionario(a): " + funcionario[i] + " utiliza: " + mediaPorc + " reais dos recursos da empresa");
        if (idade[i] >= 30 && mediaPorc >= 600)
        {
          Console.WriteLine("O funcionario(a): " + funcionario[i] + " tem: " + idade[i] + " anos,  e utiliza +30% dos recursos da empresa");
        }
        else if (idade[i] >= 18 && mediaPorc >= 400)
        {
          Console.WriteLine("O funcionario(a): " + funcionario[i] + " tem: " + idade[i] + " anos,  e utiliza +20% dos recursos da empresa");
        }
        else
        {
          Console.WriteLine("o funcionário(a) : " + funcionario[i] + " ate atende aos requisitos");
        }
        Console.WriteLine("-------------------------------------");
      }

      Console.ReadKey();
    }
  }
}