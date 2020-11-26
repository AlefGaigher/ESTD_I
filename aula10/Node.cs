using System;
public class Node
{
    public Pessoa data;
    public Node next;
    public Node(Pessoa p)
    {
        data = p;
        next = null;
    }
    
    ///public Node()
    //{
    //    data = null;
    //    next = null;
    //}
    //public Node(string nome, int idade)
    //{
    //    data = new Pessoa(nome, idade);
    //    next = null;
    //}
}
