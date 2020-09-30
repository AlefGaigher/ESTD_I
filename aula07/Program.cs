using System;
using System.Diagnostics;

namespace aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lista = new LinkedList();

            Console.WriteLine($"Vazio? {lista.IsEmpity()}");

            lista.AddOrdered(10);
            lista.AddOrdered(1);
            lista.AddOrdered(99);
            lista.AddOrdered(5);
            lista.AddOrdered(1000);
            Console.WriteLine($"Vazio? {lista.IsEmpity()}");

            Console.WriteLine(lista.Find(999));
            Console.WriteLine(lista.Find(5));

            lista.PrintList();
        }
    }
}
