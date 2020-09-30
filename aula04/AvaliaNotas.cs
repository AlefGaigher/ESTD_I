using System;
using System.Collections.Generic;
using System.Text;

    public class AvaliaNotas
    {
        private float[] notas;
        private float media;
        public AvaliaNotas()
        {
            notas = new float[5];
            media=0;
        }
        public void LerNotas()
        {
            for(int i =0; i<notas.Length;i++)
            {
                Console.WriteLine($"Digite a {i+1} nota");
                notas[i] =Convert.ToSingle(Console.ReadLine());
            }
        }
        public void CalcularMedia()
        {
            float soma = 0;
            for(int i=0; i<notas.Length;i++)
            {
                soma += notas[i];
            }
            media = soma / notas.Length;
        }
        public void MostraNotas()
        {
            for(int i=0; i<notas.Length;i++)
            {
                var notaAtual = notas[i];
                if(notaAtual < media)
                {
                    Console.WriteLine($"Nota = {notas[i]}, e esta abaixo da média.");
                }
                else if (notaAtual> media)
                {
                    Console.WriteLine($"Nota = {notas[i]}, e esta acima da média.");
                }
                else
                {
                    Console.WriteLine($"Nota = {notas[i]}, e esta na média.");
                }
            }
        }

    }
