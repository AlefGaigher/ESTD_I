using System;
using System.Diagnostics;

namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 1,5,6,45,0,-1,12 };
            int[] vetor2 = new int[] { 14,0,3,2,25,-1,18 };
            int[] vetor3 = new int[] { 1,23,31,22,2,-10,11 };
            int[] vetor4 = new int[] { 2,1,7,8,4,9,3,15 };

            Stopwatch sw = new Stopwatch();
            Random random = new Random();

            int[] vetor5 = new int[100000];
            for(int i = 0; i < vetor5.Length; i++)
            {
                vetor5[i] = random.Next();
            }

            Ordenador order = new Ordenador();

            sw.Start();
            order.SelectionSort(vetor5);
            sw.Stop();
            Console.WriteLine($"SelectionSort = {sw.Elapsed.ToString()}");

            sw.Start();
            order.Bubblesort(vetor5);
            sw.Stop();
            Console.WriteLine($"BubbleSort = {sw.Elapsed.ToString()}");

            sw.Start();
            order.BubblesortV2(vetor5);
            sw.Stop();
            Console.WriteLine($"BubbleSortV2 = {sw.Elapsed.ToString()}");
            
            sw.Start();
            order.InsertionSort(vetor5);
            sw.Stop();
            Console.WriteLine($"InsertionSort = {sw.Elapsed.ToString()}");

            order.Bubblesort(vetor);
            order.PrintVetor(vetor);
            Console.WriteLine("----------");

            order.SelectionSort(vetor2);
            order.PrintVetor(vetor2);
            Console.WriteLine("----------");
            
            order.BubblesortV2(vetor3);
            order.PrintVetor(vetor3);
            Console.WriteLine("----------");

            order.InsertionSort(vetor4);
            order.PrintVetor(vetor4);
        }
    }
}
