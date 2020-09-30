using System;
class Program
{
    static void Main(string[] args)
    {
        bool terminou = false;

        JogoForca jogo = new JogoForca();
        jogo.SortearPalavra();

        do
        {
            jogo.ExibirStatusDoJogo();
            char chute = Console.ReadKey().KeyChar;
            jogo.ChutarLetra(chute);
            terminou = jogo.IsFimDeJogo();
        } while (!terminou);

    }
}