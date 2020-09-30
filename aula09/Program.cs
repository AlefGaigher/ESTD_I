using System;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Pilha!");
            Pilha pilha = new Pilha();
            pilha.Push(14);
            pilha.Push(25);
            pilha.Push(36);

            Console.WriteLine($"Topo={pilha.Peek()}");
            Console.WriteLine($"Qtd={pilha.Count()}");

            pilha.Pop();
            pilha.Pop();

            Console.WriteLine($"Topo={pilha.Peek()}");
            Console.WriteLine($"Qtd={pilha.Count()}");

            pilha.Pop();

            Console.WriteLine($"Topo={pilha.Peek()}");
            Console.WriteLine($"Qtd={pilha.Count()}");
        }
    }
}
