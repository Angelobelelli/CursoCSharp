using System;
using System.Globalization; // Adicione esta linha para usar CultureInfo
using ConsoleApp1.Teste;
using ConsoleApp1.MediaUcl;

namespace ConsoleApp1
{
    class Program
    {
    static void Main()
    {
      // Seus outros códigos (Carro, Variaveis, etc.)
      // Carro meuCarro = new Carro();
      // meuCarro.Ligar();
      // meuCarro.Desligar();

      // Variaveis minhasVariaveis = new Variaveis();
      // minhasVariaveis.TiposVariaveis();

      // Media minhaMedia = new Media();
      // minhaMedia.mediasdasprovas();

      Console.WriteLine("Digite a nota da A1 (use ponto como separador decimal, ex: 7.5):");
      double a1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Digite a nota da P1:");
      double p1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Digite a nota da A2:");
      double a2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Digite a nota da P2:");
      double p2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

      double n1 = (a1 * 0.3) + (p1 * 0.7);
      double n2 = (a2 * 0.3) + (p2 * 0.7);
      double mediaAtual = (n1 + n2) / 2;

      Console.WriteLine($"N1: {n1.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"N2: {n2.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"Média Final: {mediaAtual.ToString("F2", CultureInfo.InvariantCulture)}");


      double mediaFinal,notaProvaRecuperacao;
      
      if (mediaAtual > 7)
      {
        Console.WriteLine("Você esta liberado 15 dias antes, boas ferias");
      }
      else if (mediaAtual >= 3)
      {
        Console.WriteLine("Você esta de recuperação e precisa tirar: ");
         notaProvaRecuperacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        mediaFinal = (mediaAtual + notaProvaRecuperacao) / 2;
        if (mediaFinal >= 5)
        {
          Console.WriteLine("Você foi aprovado na Recuperação.");
        }
        else
        {
          Console.WriteLine("Reprovado na Recuperação.");
        }
      }
      else
      {
        Console.WriteLine("Você reprovou na materia");
      }
                  
      
        }
    }
}