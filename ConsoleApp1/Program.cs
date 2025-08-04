
using ConsoleApp1.Teste;

namespace ConsoleApp1;

class Program
{
  static void Main()
  {

    Carro meuCarro = new Carro();
    meuCarro.Ligar();
    meuCarro.Desligar();

    Variaveis minhasVariaveis = new Variaveis();
    minhasVariaveis.TiposVariaveis();

  }
}
