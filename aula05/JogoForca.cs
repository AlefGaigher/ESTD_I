using System;
using System.Collections;
using System.Linq;

public class JogoForca
{
    //Atributos
    string palavraAlvo;
    //string palavraExibida; //_ _ a _ _
    string[] listaPalavras;
    ArrayList chutesCertos;
    ArrayList chutesErrados;
    const int maxErros = 5;
    //Metodos
    public JogoForca()
    {
        listaPalavras = new string[] { "uvv", "casa", "borboleta" };
        chutesCertos = new ArrayList();
        chutesErrados = new ArrayList();
    }
    public string SortearPalavra()
    {
        Random rnd = new Random();
        int indiceSorteado = rnd.Next(0, listaPalavras.Length - 1);
        palavraAlvo = listaPalavras[indiceSorteado];
        return palavraAlvo;
    }
    public bool ChutarLetra(char chute)
    {
        if (chutesCertos.Contains(chute) || chutesErrados.Contains(chute))
        {
            Console.WriteLine("Letra já chutada. Escolha outra.");
            return false;
        }

        if (palavraAlvo.Contains(chute)){
            chutesCertos.Add(chute);
            return true;
        }
        else
        {
            chutesErrados.Add(chute);
            return false;
        }
    }
    public bool IsFimDeJogo()
    {
        if (chutesErrados.Count == 5)
        {
            Console.WriteLine("Você Perdeu");
            return true;
        }

        int numCaracteresDiferentesNaPalavra = palavraAlvo.Distinct().Count();
        if(chutesCertos.Count == numCaracteresDiferentesNaPalavra)
        {
            Console.WriteLine("Você Ganhou");
            return true;
        }

        return false;
    }
    public void ExibirStatusDoJogo()
    {
        Console.WriteLine("Chutes Certos");
        for (int i = 0; i < chutesCertos.Count; i++)
        {
            Console.Write(chutesCertos[i] + " ");
        }
        Console.WriteLine("Chutes Errados");
        for (int i = 0; i < chutesErrados.Count; i++)
        {
            Console.Write(chutesErrados[i] + " ");
        }
        Console.WriteLine($"Você ainda tem: {maxErros - chutesCertos.Count - chutesErrados.Count} chutes");

    }
}