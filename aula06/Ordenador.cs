using System;

namespace aula06
{
    public class Ordenador
    {
        public void Bubblesort( int[] vetor )
        {
            for(int j=0;j<vetor.Length;j++)
            {
                for(int i=0; i<vetor.Length - 1;i++)
                {
                    if(vetor[i]>vetor[i+1])
                    {
                        int aux = vetor[i];
                        vetor[i]= vetor[i+1];
                        vetor[i+1]= aux;

                    }
                }
            }
        }
         public void SelectionSort(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                int menorIndice = i;
                for (int j = i +1; j < vetor.Length; j ++)
                {
                    if(vetor[j] < vetor[menorIndice])
                    {
                        menorIndice = j;
                    }
                }
                int aux = vetor[i];
                vetor[i] = vetor[menorIndice];
                vetor[menorIndice] = aux;
            }
        }
        public void BubblesortV2(int[] vetor)
        {
             for(int j=0;j<vetor.Length; j++)
            {
                for(int i=0; i<vetor.Length -1 - j;i++)
                {
                    if(vetor[i]>vetor[i+1])
                    {
                        int aux = vetor[i];
                        vetor[i]= vetor[i+1];
                        vetor[i+1]= aux;
                    }
                }
            }
        }
        public void InsertionSort(int[] vetor)
        {
            for(int i = 1; i< vetor.Length; i++)
            {
                int aux = vetor[i];
                int indice = i;
                while(indice > 0 && aux < vetor[indice-1])
                {
                    vetor[indice] = vetor[indice-1];
                    indice--;
                }
                vetor[indice] = aux;
            }
        }
        public void PrintVetor(int[] vetor)
        {
            for(int i = 0;i<vetor.Length;i++)
            {
                Console.WriteLine($"v[{i}] = {vetor[i]}");
            }
        }
    }
}