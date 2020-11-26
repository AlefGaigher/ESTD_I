using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Árvore Binária!");
        Node raiz = new Node(27);
        int op = 0;
        do
        {
            Console.WriteLine("O Que deseja fazer? \n0 - Sair, \n 1- add \n 2- Print");
            op =  Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Digite o valor do nó:");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    raiz.Add(valor);
                    break;
                case 2:
                    raiz.PrintInOrder();
                    break;
                default:
                    Console.WriteLine("opção invalida, tente novamente.");
                    break;
            }
        } while (op != 0);
    }
}
