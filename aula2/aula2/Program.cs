
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Digite um numero: ");
            // string entrada = Console.ReadLine();
            // int numero;

            // if (int.TryParse(entrada, out numero))
            // {
            //     Console.WriteLine("Você digitou: " + numero);

            //     if (numero % 2 == 0)
            //     {
            //         Console.WriteLine("O numero é par");

            //     }
            //     else
            //     {
            //         Console.WriteLine("O numero não é par");

            //     }


            // }
            // else
            // {
            //     Console.WriteLine("Entrada inválida! Digite um número inteiro.");
            //     return;
            // }


            Console.WriteLine("Digite uma temperatura em celsius: ");
            string entrada = Console.ReadLine();
            double temp;

            if (double.TryParse(entrada, out temp))
            {
                double valorFinal = (temp * 9 / 5) + 32;
                Console.WriteLine(valorFinal);
            }
           
        }
            

        }
    }
