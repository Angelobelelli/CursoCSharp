
namespace ConsoleApp1.Teste;

public class Variaveis
{
    public void TiposVariaveis()
    {
        int numero1 = 1000;
        bool ativo = true;

        char letra = 'a';
        string palavra = "        Angelo Belelli        ";
        string nomeSemEspaço = palavra.Trim();

        string texto = "Este curso é muito bom";

        bool comecaComALetraA = nomeSemEspaço.StartsWith("A");
        string textoAposReplace = nomeSemEspaço.Replace('e', '7');
        bool contem = texto.Contains("curso");
        bool igual = texto.Equals("curso"); // da false pois precisaria ser exatamente oq tem na string 


        // Console.WriteLine(palavra);
        // Console.WriteLine(nomeSemEspaço);
        // Console.WriteLine(comecaComALetraA);
        // Console.WriteLine(textoAposReplace);
        // Console.WriteLine(contem);

    }   
}
