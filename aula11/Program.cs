using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Árvore Binária!");

        Node raiz;
        raiz = new Node(5, 
                    new Node(4),
                    new Node(6,
                            null,
                            new Node(7)
                    )
                );
        raiz.PrintIrOrdem();
        Console.WriteLine();

        raiz.PrintPosOrdem();
        Console.WriteLine();

        raiz.PrintPreOrdem();
        Console.WriteLine();

        Console.WriteLine(raiz.Pertence(7));
        Console.WriteLine(raiz.Pertence(100));

        Console.WriteLine();
        Console.WriteLine($"Altura = {raiz.Altura()}");

        Console.WriteLine();
        Console.WriteLine($"# de nós = {raiz.Count()}");

        //1)Tipo de arvore: CHEIA, DEGENARADA, NORMAL

        //2)Contar quantas folhas a árvore

        //3)Contar quantos números pares a árvore tem

        //4)Contar quantos números são menores que um valor X 
        //(passado por parâmetro

    }
}