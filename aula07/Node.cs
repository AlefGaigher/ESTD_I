using System;
using System.Diagnostics;

namespace aula07
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            data = -1;
            next = null;
        }

        public Node(int valor)
        {
            data = valor;
            next = null;
        }
        
    }
}