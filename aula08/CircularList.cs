using System;
using System.Collections.Generic;
using System.Text;

public class CircularList
{
    public Node head;
    public CircularList()
    {
        head = null;
    }
    public void Add(int valor)
    {
        Node aux = head;
        var newNode = new Node(valor);
        if (head != null)
        {
            while (aux.next != head)
            {
                aux = aux.next;
            }
        }
        else
        {
            aux = newNode;
        }
        newNode.next = head;
        head = newNode;
        aux.next = head;
    }
    public void Print()
    {
        if (head == null)
        {
            Console.Write("Lista Vazia.");
        }
        Console.Write("[HEAD]");
        var aux = head;

        do
        {
            Console.Write($"-> [{aux.data}]");
            aux = aux.next;
        } while (aux != head);

        Console.Write("-> [NULL]");
    }
}