using System;

class Program
{
    static void Main(string[] args)
    {
        AvaliaNotas avaliaNotas = new AvaliaNotas();
        avaliaNotas.LerNotas();
        avaliaNotas.CalcularMedia();
        avaliaNotas.MostraNotas();  
    }
}